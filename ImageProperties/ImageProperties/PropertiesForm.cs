using MetadataExtractor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageProperties
{
    public partial class PropertiesForm : Form
    {
        private static readonly HashSet<string> ImageExtensions = new HashSet<string>
        {
            ".jpg", ".tiff", ".gif", ".bmp", ".png" ,".pcx"
        };

        private static readonly Dictionary<long, string> CompressionTypes = new Dictionary<long, string>()
        {
            {1, "Uncompressed"},
            {2, "CCITT modified Huffman RLE"},
            {32773, "PackBits"},
            {3, "CCITT3"},
            {4, "CCITT4"},
            {5, "LZW"},
            {6, "JPEG_old"},
            {7, "JPEG_new"},
            {32946, "DeflatePKZIP"},
            {8, "DeflateAdobe"},
            {9, "JBIG_85"},
            {10, "JBIG_43"},
            {11, "JPEG"},
            {12, "JPEG"},
            {32766, "RLE_NeXT"},
            {32809, "RLE_ThunderScan"},
            {32895, "RasterPadding"},
            {32896, "RLE_LW"},
            {32897, "RLE_HC"},
            {32947, "RLE_BL"},
            {34661, "JBIG"},
            {34713, "Nikon_NEF"},
            {34712, "JPEG2000"}
        };

        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void btOpenFolder_Click(object sender, EventArgs e)
        {
            if (dialogBrowseFolder.ShowDialog() == DialogResult.OK)
            {
                var path = dialogBrowseFolder.SelectedPath;
                lbSelectedPath.Text = path;
                UpdateGridView(path);
            }
        }

        private void UpdateGridView(string path)
        {
            dgImages.Rows.Clear();
            DirectoryInfo d = new DirectoryInfo(path);

            List<FileInfo> files = d.GetFiles("*.*")
                                    .Where(file => ImageExtensions.Contains(file.Extension.ToLower()))
                                    .ToList();
            foreach (FileInfo file in files)
            {
                if (file.Extension != ".pcx")
                {
                    var image = Image.FromFile(file.FullName);
                    dgImages.Rows.Add(new object[] {
                        file.Name,
                        image.Size.Width.ToString() + "X" + image.Size.Height.ToString(),
                        image.HorizontalResolution + "X" + image.VerticalResolution,
                        Image.GetPixelFormatSize(image.PixelFormat),
                        GetCompressionType(image)
                    });
                }
                else
                {
                    dgImages.Rows.Add(GetPcxMetadata(file));
                }
            }
        }

        private object[] GetPcxMetadata(FileInfo file)
        {
            var directories = ImageMetadataReader.ReadMetadata(file.FullName);
            var metadata = new Dictionary<string, string>();

            byte[] bytes = new byte[3];
            using (var reader = new BinaryReader(new FileStream(file.FullName, FileMode.Open)))
            {
                reader.Read(bytes, 0, 3);
            }
            var isCompressed = bytes[2] == 1;

            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    metadata[$"{directory.Name} - {tag.Name}"] = tag.Description;
                }
            }

            return new string[]
            {
                file.Name,
                CalcPcxSize(metadata["PCX - X Min"], metadata["PCX - X Max"],  
                            metadata["PCX - Y Min"], metadata["PCX - Y Max"]),
                $"{metadata["PCX - Horizontal DPI"]}X{metadata["PCX - Vertical DPI"]}",
                metadata["PCX - Color Planes"],
                isCompressed ? "RLE" : "No compression"
            };
        }

        private string CalcPcxSize(string xMinStr, string xMaxStr, string yMinStr, string yMaxStr)
        {
            try
            {
                var xMin = int.Parse(xMinStr);
                var xMax = int.Parse(xMaxStr);
                var yMin = int.Parse(yMinStr);
                var yMax = int.Parse(yMaxStr);
                return $"{xMax - xMin + 1}X{yMax - yMin + 1}";
            }
            catch (Exception)
            {
                return "Cannot get size";
            }
        }

        private string GetCompressionType(Image image)
        {
            int compressionId;
            try
            {
                compressionId = BitConverter.ToInt16(image.GetPropertyItem(0x0103).Value, 0);
            }
            catch (Exception)
            {
                return "Cannot get compression info";
            }
            if(!CompressionTypes.TryGetValue(compressionId, out var compressionType))
            {
                return "Undefined compression type";
            }
            return compressionType;
        }
    }
}
