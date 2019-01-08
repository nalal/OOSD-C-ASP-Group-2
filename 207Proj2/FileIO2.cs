using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _207Proj2
{
    /* Creates or opens a file where customer object data can be stored
    * Reads from this file and writes to the file when new customer objects 
    * are input via the form
    * Author: Chad Dundas Smith 
    * Date: Dec 15, 2018
    */
    public static class FileIO2
    {
        // string variable containing the name of the text file
        const string path = "Packages.txt";

        // writes data from the array to the file
        //public static void WriteData(List<Package> packages)
        //{
        //    // create filestream and streamwriter variable
        //    FileStream fs = null;
        //    StreamWriter sw = null;
        //    try
        //    {
        //        // open the file for writing; overwrite old content
        //        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
        //        sw = new StreamWriter(fs);
        //        // write data 
        //        foreach(Package p in packages)
        //            sw.WriteLine(c.ToFileString());

        //    }
        //    // catching exceptions if there is an error instead of 
        //    // instead of crashing the program
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Error while writing to the file: " + 
        //            ex.Message, ex.GetType().ToString());
        //    }
        //    finally
        //    {
        //        if (sw != null) sw.Close(); // also closes fs
        //    }
        //}

        // reads data from the file, puts in a list, and returns it
        public static List<Package> ReadData()
        {
            //creates list of packages
            List<Package> packages = new List<Package>();
            // create filestream and streamwriter variable
            FileStream fs = null;
            StreamReader sr = null;
            string line; // for reading
            string[] fields; // result from splitting the line
            //open the file for reading and read number into data array
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                while(!sr.EndOfStream) // while there is data in the file
                {
                    line = sr.ReadLine(); // read the next line
                    fields = line.Split(','); //split lines into fields

                    // converting types to match that of the necessary paramaters
                    // for the Package object
                    Package p = new Package(Convert.ToInt32(fields[0]),
                        Convert.ToString(fields[1]),
                        Convert.ToDateTime(fields[2]),
                        Convert.ToDateTime(fields[3]),
                        Convert.ToString(fields[4]),
                        Convert.ToDecimal(fields[5]),
                        Convert.ToDecimal(fields[6]));
                    packages.Add(p); // adding package object to the packages list
                }
            }
            // catching exceptions if there is an error instead of 
            // instead of crashing the program
            catch (FormatException)
            {
                MessageBox.Show("File contains incorrectly formatted data. Aborting reading");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error while reading the file: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                // close the file if open
                if (sr != null) sr.Close(); // file stream gets closed too
            }
            return packages;

        }
    }
}
