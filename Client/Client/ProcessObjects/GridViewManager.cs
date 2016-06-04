using Client.HelpingForm;
using Client.Models;
using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ProcessObjects
{
    public class GridViewManager
    {
        ContextMenu menu = null;
        MenuItem sortItem = null;
        string currentPropertyName = null;
        public Type currentType { get; set; }

        public RefreshGridView RefresingMainView { get; set; }

        public GridViewManager()
        {
            menu = new ContextMenu();
            sortItem = new MenuItem("Filter");
            menu.MenuItems.Add(sortItem);
            sortItem.Click += new EventHandler(MenuClick);
        }

        public void ShowCustomMenu(object sender, System.Windows.Forms.MouseEventArgs e, SoaResourceModel resource)
        {
            DataGridView dgV = sender as DataGridView;

            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgV.HitTest(e.X, e.Y).ColumnIndex;
                currentPropertyName = dgV.Columns[currentMouseOverRow].DataPropertyName;
                currentType = resource.DataBindedType;
                menu.Show(dgV, new Point(e.X, e.Y));
            }
        }

        public void MenuClick(object sender, EventArgs e)
        {
            Type propertyType = currentType.GetProperty(currentPropertyName).PropertyType;
            
            FilterDataType fdType;

            switch (Type.GetTypeCode(propertyType))
            {
                case TypeCode.Int32:
                case TypeCode.Decimal:
                case TypeCode.Int64:
                case TypeCode.Double:
                    fdType = FilterDataType.NUMERIC;
                    break;
                default:
                    fdType = FilterDataType.TEXT;
                    break;
            }

            using (ChooseFilterForm filterForm = new ChooseFilterForm(fdType))
            {
                filterForm.ShowDialog();

                if (filterForm.ResultFilter != null)
                {
                    GridDataFilter filt = filterForm.ResultFilter;
                    filt.PropertyName = currentPropertyName;
                    RefresingMainView(filt);
                }
            }
        }
    }

    public delegate void RefreshGridView(GridDataFilter filter);
}
