using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace App1_DropDownList.Models
{
    public class PartsViewModel
    {
        public string DropDownValue { get; set; }
        public IEnumerable<SelectListItem> DropDownList { get; set; }

    }
    public class utility
    {
        public IEnumerable<string> GetOptions()
        {
            return new List<string>
            {
                "Part Number",
                "Part Name",
                "Part Desc",
                "Customer Number",
                "Customer Name",
                "Customer Desc",
                "Order Name",
                "Order Date",
            };
        }
        public IEnumerable<SelectListItem> SetOptions(IEnumerable<string> options)
        {
            // Create an instance of List of type SelectListItem
            var selectList = new List<SelectListItem>();

            //Set values for each options the list
            foreach (var option in options)
            {
                var value = "";
                if (option == "Part Number")
                {
                    value = "PNumber";
                }
                else if (option == "Part Name")
                {
                    value = "PName";
                }
                else if (option == "Part Desc")
                {
                    value = "PDesc";
                }
                else if (option == "Customer Number")
                {
                    value = "CNumber";
                }
                else if (option == "Customer Name")
                {
                    value = "CName";
                }
                else if (option == "Customer Desc")
                {
                    value = "CDesc";
                }
                else if (option == "Order Name")
                {
                    value = "OName";
                }
                else if (option == "Order Date")
                {
                    value = "ODate";
                }
                //Add value and text to display in List of type SelectListItem
                selectList.Add(new SelectListItem
                {
                    Value = value,
                    Text = option
                });
            }
            return selectList;
        }
    }
    
}
