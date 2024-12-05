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
                            foreach (string s in a)
                            {
                                int number;
                                bool b = int.TryParse(s, out number);
                                if (b)
                                {
                                    sb.Append(Convert.ToChar(number));
                                    //Debug.WriteLine(Convert.ToChar(number));
                                }
                                //Debug.WriteLine(s);

                                string sb1 = sb.ToString();
                                if (sb1.Contains("Microsoft Windows Production PCA 2011") && sb1.Contains("Microsoft Root Certificate Authority 2010"))
                                {
                                    PCA2011.Text = "Microsoft Windows Production PCA 2011";
                                    CA20101.Text = "Microsoft Root Certificate Authority 2010";
                                }
                                if (sb1.Contains("Microsoft Corporation UEFI CA 2011") && sb1.Contains("Microsoft Corporation Third Party Marketplace Root"))
                                {
                                    CA2011.Text = "Microsoft Corporation UEFI CA 2011";
                                    CA201102.Text = "Microsoft Corporation Third Party Marketplace Root";
                                }
                                if (sb1.Contains("Windows UEFI CA 2023") && sb1.Contains("Microsoft Root Certificate Authority 2010"))
                                {
                                    CA2023.Text = "Windows UEFI CA 2023";
                                    CA20102.Text = "Microsoft Root Certificate Authority 2010";
                                }


                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
