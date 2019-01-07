using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_ADMIN_OOSD
{
    public class FileIO
    {
        //-Create public strings
            //Use this string to identify things
        public static string Name = "";
            //_DIR vars
                //Program DIR
        public static string localD = Environment.CurrentDirectory;
                //Main data DIR
        public static string localAD = Path.Combine(localD, "Data");
                //Packages DIR
        public static string localPD = Path.Combine(localAD, "Packages");
                //Products DIR
        public static string localPrD = Path.Combine(localAD, "Products");
                //Product Suppliers DIR
        public static string localPrsD = Path.Combine(localAD, "ProductSuppliers");
                //Suppliers DIR
        public static string localSD = Path.Combine(localAD, "Suppliers");
                //Packages Product Suppliers DIR
        public static string localPpsD = Path.Combine(localAD, "PackagesProductSuppliers");
            //_Active vars
                //Active data for file edit
        public static List<string> activeData = new List<string>();
                //List box entries
        public static List<string> lbList = new List<string>();

        //-Init directories
        public static void initDIR()
        {
            //Make DIRs
            Directory.CreateDirectory(localAD);
            //Directory.CreateDirectory(localPD);
            //Directory.CreateDirectory(localPrD);
            //Directory.CreateDirectory(localPrsD);
            //Directory.CreateDirectory(localSD);
            //Directory.CreateDirectory(localPpsD);
        }

        //-File management
            //Save content to file
        public static void save(string id, List<string> content)
        {
                //Create target to make file
            string filemake = Path.Combine(localAD, id);
                //Validate input
            if (File.Exists(filemake) == false &&
                ErrHandle.isNonNull(content[0]) == false &&
                ErrHandle.isNonNull(id) == false)
            {
                    //Make and write to file
                File.Create(filemake).Dispose();
                File.WriteAllLines(filemake, content);
            }
            else
            {
                    //Catch error and display message
                ErrHandle.message();
            }
        }
        public static void edit(string id, int line, string content)
        {
                //Create target to edit file
            string fileed = Path.Combine(localAD, id);
                //Verify input
            if (File.Exists(fileed) == true && 
                ErrHandle.isNonNull(content) == false &&
                ErrHandle.isNonNull(line.ToString()) == false &&
                ErrHandle.isNonNull(id) == false)
            {
                string[] data = File.ReadAllLines(fileed);
                data[line] = content;
                File.WriteAllText(fileed, content);
            }
            else
            {
                ErrHandle.message();
            }
        }

        //-Error checking
            //Check for file to exist in dir
        public static bool fileIsThere(string file)
        {
            bool result = false;
            if (File.Exists(file) == true)
            {
                result = true;
            }
            return result;
        }

        //-Populate listbox
        public static void loadFromFiles(string dir, List<string> ls)
        {
            string filemake = Path.Combine(localAD, id);
            //Check if file exists
            if (File.Exists(filemake) != true)
            {
                i.Replace(dir, "");
                ls.Add(i);
            }
        }
    }
}
