using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace AuthoringTagHelpers.TagHelpers
{
    public class TextTagHelper : TagHelper
    {
        public string Placeholder { get; set; }

        public string Type { get; set; }

        public string Id { get; set; }

        public string Required { get; set; }

        public string Column { get; set; }

        public string Label { get; set; }

        public string Icon { get; set; }

        public string ClassName { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
           
            var tag = "";         

            tag += @"<div class=""form-group"">";
   
            if (!string.IsNullOrEmpty(Label))
                tag += @$"<label for= ""{this.Id}"" >{this.Label}</label >";

            if (!string.IsNullOrEmpty(Icon))
                tag += @$"<div class=""input - group - prepend""> < span class=""input-group-text"" id=""basic-addon1"">{this.Icon}</span></div>";               

            var input =  @$"<input type=""{this.Type}"" required =""{this.Required}""  placeholder=""{this.Placeholder}"" class=""{this.ClassName}"" id=""{this.Id}""/>";

            tag += input.ToString();

            tag += "</div>";
          
            output.PreContent.SetHtmlContent(tag);        
            base.Process(context, output);
        }
    }
}
