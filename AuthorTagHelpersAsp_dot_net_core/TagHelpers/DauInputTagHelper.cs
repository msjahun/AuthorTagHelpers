using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorTagHelpersAsp_dot_net_core.TagHelpers
{
    public class DauInputTagHelper : TagHelper
    {

      
        public string Type { get; set; }
        public ModelExpression AspFor { get; set; }
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; //Replaces <email> tag with <a> anchor tag
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
         
            sb.AppendFormat("<input  type=\"{0}\" class=\"form-control\">{1}</input>", this.Type, this.AspFor.Name);
            sb.AppendFormat("<span  class=\"glyphicon glyphicon-lock form-control-feedback\"></span>");
           

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
