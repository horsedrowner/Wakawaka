﻿using System;
using System.Xml.Linq;

namespace Wakawaka.Documentation
{
    /// <summary>
    /// Represents the XML documentation for a type (e.g. class, interface, 
    /// structure, enum or delegate).
    /// </summary>
    public class Type : Member
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Type"/> class with the
        /// specified ID string and XML documentation.
        /// </summary>
        /// <param name="id">The ID string that idenfities the member.</param>
        /// <param name="member">
        /// The <see cref="XElement"/> object that contains the XML 
        /// documentation for the member.
        /// </param>
        public Type(string id, XElement member)
            : base(id, member) { }

        /// <summary>
        /// Renders a Markdown representation of the <see cref="Type"/>.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="System.IO.TextWriter"/> object to write to.
        /// </param>
        public override void Render(System.IO.TextWriter writer)
        {
            writer.WriteLine(Markdown.Heading(ToString()));
            writer.WriteLine(Summary);
            writer.WriteLine();

            if (Example != null)
            {
                writer.WriteLine(Markdown.Heading("Examples", 2));
                writer.WriteLine(Example);
            }
        }

        /// <summary>
        /// Returns a string representation of the <see cref="Type"/>.
        /// </summary>
        /// <returns>A string containing the name of the type.</returns>
        public override string ToString()
        {
            return String.Format("{0} Type", ID.Name);
        }
    }
}
