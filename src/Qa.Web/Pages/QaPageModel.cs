using Qa.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qa.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class QaPageModel : AbpPageModel
    {
        protected QaPageModel()
        {
            LocalizationResourceType = typeof(QaResource);
        }
    }
}