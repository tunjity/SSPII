using Microsoft.AspNetCore.Mvc.Rendering;

namespace SSP.Infrastructure.Utility
{
    public static class AllFunction
    {
        public static SelectList ToSelectList<T>(this List<T> list, string idPropertyName, string namePropertyName = "Name")
        where T : class, new()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            if (list.Count > 0)
            {
                list.ForEach(item =>
                {
                    selectListItems.Add(new SelectListItem
                    {
                        Text = item.GetType().GetProperty(idPropertyName).GetValue(item).ToString(),
                        Value = item.GetType().GetProperty(namePropertyName).GetValue(item).ToString()
                    });
                });
            }
            return new SelectList(selectListItems, "Value", "Text");
        }
    }

    public class SelectForDropdown { public string Id { get; set; }public string Value { get; set; }}

}
