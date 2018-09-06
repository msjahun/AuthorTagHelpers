using AuthorTagHelpersAsp_dot_net_core.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorTagHelpersAsp_dot_net_core.TagHelpers
{

    /// <summary>
    /// The modal-body portion of a Bootstrap modal dialog
    /// </summary>
    [HtmlTargetElement("modal-body", ParentTag = "modal")]
    public class ModalBodyTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var childContent = await output.GetChildContentAsync();

            //typeof ModalTagHelper, which is typeof parent tag
            var modalContext = (ModalContext)context.Items[typeof(ModalTagHelper)];

            //childContent is passed to modalContext and will be accessed in modal parent
            modalContext.Body = childContent;

            //output is suppressed so that we don't have any content rendered
            output.SuppressOutput();
        }
    }
}
