using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoForm
{
    interface InterfaceDBController
    {
        String GetDataTable(int Table);
        String GetDataSetRow(int Table, int Row1, int Row2);
        void setDataSet();
        void ViewDataTable(int Table, string TableName);
        void ViewDataTable(int Table);
        void ExecuteQuery(string AdapterType);
        void AdapterType(string CommadType);
        void Connect();
        void Close();
        void Open();
    }
}
