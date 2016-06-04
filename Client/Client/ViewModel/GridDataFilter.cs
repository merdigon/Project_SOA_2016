using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class GridDataFilter
    {
        public GridDataFilter(FilterType type, FilterDataType dType)
        {
            FilterType = type;
            FilterDataType = dType;
        }

        public string Value { get; set; }

        public FilterDataType FilterDataType { get; set; }

        public FilterType FilterType { get; set; }

        public string PropertyName { get; set; }

        public override string ToString()
        {
            switch (FilterType)
            {
                case FilterType.LESS: return "<";
                case FilterType.LESSOREQUAL: return "<=";
                case FilterType.CONTAINS: return "contains";
                case FilterType.EQUAL: return "==";
                case FilterType.MORE: return ">";
                case FilterType.MOREOREQUAL: return ">=";
                case FilterType.STARTS: return "starts with";
                case FilterType.ENDS: return "ends with";
                default: return string.Empty;
            }
        }

        public static List<GridDataFilter> GetAll(FilterDataType type)
        {
            if (type == FilterDataType.NUMERIC)
            {
                return new List<GridDataFilter>(){ 
                    new GridDataFilter(FilterType.LESS, FilterDataType.NUMERIC),
                    new GridDataFilter(FilterType.LESSOREQUAL, FilterDataType.NUMERIC),
                    new GridDataFilter(FilterType.EQUAL, FilterDataType.NUMERIC),
                    new GridDataFilter(FilterType.MORE, FilterDataType.NUMERIC),
                    new GridDataFilter(FilterType.MOREOREQUAL, FilterDataType.NUMERIC),
                };
            }
            else{
                return new List<GridDataFilter>(){ 
                    new GridDataFilter(FilterType.EQUAL, FilterDataType.TEXT),
                    new GridDataFilter(FilterType.STARTS, FilterDataType.TEXT),
                    new GridDataFilter(FilterType.CONTAINS, FilterDataType.TEXT),
                    new GridDataFilter(FilterType.ENDS, FilterDataType.TEXT)
                };
            }
        }
    }

    public enum FilterDataType
    {
        NUMERIC,
        TEXT
    }

    public enum FilterType
    {
        EQUAL,
        MORE,
        STARTS,
        CONTAINS,
        ENDS,
        LESS,
        MOREOREQUAL,
        LESSOREQUAL
    }
}
