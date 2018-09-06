using AuthorTagHelpersAsp_dot_net_core.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorTagHelpersAsp_dot_net_core.TagHelpers
{
    /// <summary>
    /// The modal-footer portion of Bootstrap modal dialog
    /// </summary>
    [HtmlTargetElement("modal-footer", ParentTag = "modal")]
    public class ModalFooterTagHelper : TagHelper
    {
        /// <summary>
        /// Whether or not to show a button to dismiss the dialog. 
        /// Default: <c>true</c>
        /// </summary>
        public bool ShowDismiss { get; set; } = true;

        /// <summary>
        /// The text to show on the Dismiss button
        /// Default: Cancel
        /// </summary>
        public string DismissText { get; set; } = "Cancel";


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (ShowDismiss)
            {
                output.PreContent.AppendFormat(@"<button type='button' class='btn btn-default' data-dismiss='modal'>{0}</button>", DismissText);
            }
            var childContent = await output.GetChildContentAsync();
            var footerContent = new DefaultTagHelperContent();
            if (ShowDismiss)
            {
                footerContent.AppendFormat(@"<button type='button' class='btn btn-default' data-dismiss='modal'>{0}</button>", DismissText);
            }
            footerContent.AppendHtml(childContent);

            //typeof modalTagHelper, which is type of Modal parent tag
            var modalContext = (ModalContext)context.Items[typeof(ModalTagHelper)];

            //content is assigned and passed to parent tag
            modalContext.Footer = footerContent;

            //we suppress output so that content does not get rendered
            output.SuppressOutput();
        }
    }
}
