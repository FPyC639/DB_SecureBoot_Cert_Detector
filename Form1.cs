using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace WindowsMicrosoftHashingDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fh = new OpenFileDialog
            {
                Filter = "DAT files|*.dat",
                DefaultExt = ".dat"
            };

            if (fh.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var myStream = fh.OpenFile())
                    using (var reader = new BinaryReader(myStream))
                    {
                        // Read all bytes from the file
                        var data = reader.ReadBytes((int)myStream.Length);
                        using (var mem = new StreamReader(new MemoryStream(data)))
                        {
                            string[] a = mem.ReadToEnd().Split("\n");
                            StringBuilder sb = new StringBuilder();
                            foreach(string s in a)
                            {
                                int number;
                                bool b = int.TryParse(s,out number);
                                if (b)
                                {
                                    sb.Append(Convert.ToChar(number)); 
                                    Debug.WriteLine(Convert.ToChar(number));
                                }  
                                Debug.WriteLine(s);
                                
                                string sb1 = sb.ToString();
                                if (sb1.Contains("Microsoft Windows Production PCA 2011"))
                                    PCA2011.Text = "Microsoft Windows Production PCA 2011";

                                if (sb1.Contains("Microsoft Root Certificate Authority 2010"))
                                    CA20101.Text = "Microsoft Root Certificate Authority 2010";
                            }
                            
                        }
                        //StringBuilder filteredText = new StringBuilder();
                        //// Decode the data using UTF-16 (little-endian)
                        //foreach (var i in data)
                        //    filteredText.Append(i);
                        //_ = filteredText.Length;
                        //string decodedContent = Encoding.Unicode.GetString(data);
                        
                        //foreach (var b in data)
                        //{
                        //    if (b >= 32 && b <= 126) // Printable ASCII range
                        //    {
                        //        filteredText.Append((char)b);
                        //    }
                        //}
                        //Debug.WriteLine(filteredText.ToString());
                        //Debug.WriteLine("Extracted Details:");
                        //Debug.WriteLine(decodedContent);
                        //foreach (var item in decodedContent.Split())
                        //{ Debug.WriteLine(Convert.ToChar(item)); }

                        // Analyze content for cryptographic patterns or metadata
                        

                        // Extract detailed cryptographic information
                        //string parsedDetails = ExtractCertificateDetails(decodedContent);

                        //// Display results in a debug window or a TextBox
                        //Debug.WriteLine("Extracted Details:");
                        //Debug.WriteLine(parsedDetails);

                        // Optionally show details in a multiline TextBox
                        //detailsTextBox.Text = parsedDetails;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private string ExtractCertificateDetails(string content)
        {
            // Placeholder for a method to parse and extract meaningful certificate/key details
            StringBuilder result = new StringBuilder();
            result.AppendLine("Parsed Certificate/Key Details:");

            // Example: Extract ASN.1 DER structure or other data patterns
            string[] lines = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                result.AppendLine(line);
            }

            return result.ToString();
        }
    }
}
