﻿using System.Xml.Linq;

namespace Wakawaka.Documentation.Tags
{
    /// <summary>
    /// Represents the <c>&lt;see&gt;</c> XML documentation tag.
    /// </summary>
    public class SeeTag : Tag
    {
        private ID cref;

        /// <summary>
        /// Initializes a new instance of the <see cref="SeeTag"/> class for
        /// the specified element.
        /// </summary>
        /// <param name="element">
        /// The <see cref="XElement"/> object to represent.
        /// </param>
        public SeeTag(XElement element) : base(element)
        {
        }

        /// <summary>
        /// Gets an <see cref="ID"/> object that represents the reference to a
        /// member or field.
        /// </summary>
        public ID CRef
        {
            get
            {
                if (cref == null)
                {
                    cref = new ID(Element.Attribute("cref"));
                }
                return cref;
            }
        }

        /// <summary>
        /// Renders a Markdown-formatted representation of the &lt;see&gt; tag.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="MarkdownTextWriter"/> object to write to.
        /// </param>
        public override void Render(MarkdownTextWriter writer)
        {
            CRef.Render(writer);
        }
    }
}
