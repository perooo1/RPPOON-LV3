using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class Dataset:Prototype
    {
        private List<List<string>> data;

        public Dataset()
        {
            this.data = new List<List<string>>();
        }

        public Dataset(string filePath)
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using(System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach(string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }

        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }

        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype clone()
        {
            Dataset clonedDataset = (Dataset)this.MemberwiseClone();
            clonedDataset.data = new List<List<string>>();

            for(int i=0; i < this.data.Count; i++)
            {
                clonedDataset.data.Add(new List<string>());

                for(int j=0; j< this.data[i].Count; j++)
                {
                    clonedDataset.data[i].Add(this.data[i][j]);
                }
            }

            return clonedDataset;
        }

        /*Radimo s listama pa je potrebno duboko kopiranje */

    }
}
