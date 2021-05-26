﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NLanguageTag.RegistryToSource
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class LanguageTag_Take : LanguageTag_TakeBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System;\nusing System.Collections.Generic;\n\nnamespace NLanguageTag\n{\n\tpublic readonly partial struct LanguageTag\n\t{\n\t\t/// <summary>\n\t\t/// Creates language tag that consists of specified fields of this language tag\n\t\t/// </summary>\n\t\tpublic LanguageTag Take(Field fields)\n\t\t{\n\t\t\tif (fields == Field.All)\n\t\t\t\treturn this;\n\n\t\t\tif (Language is null)\n\t\t\t{\n\t\t\t\treturn fields.HasFlag(Field.PrivateUse)\n\t\t\t\t\t? new LanguageTag(PrivateUse)\n\t\t\t\t\t: new LanguageTag(null, null, null, default, default, default);\n\t\t\t}\n\n\t\t\tswitch(fields)\n\t\t\t{\n");
            
            #line 31 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"

foreach(var s in new bool[]{false, true})
foreach(var r in new bool[]{false, true})
foreach(var v in new bool[]{false, true})
foreach(var e in new bool[]{false, true})
foreach(var p in new bool[]{false, true})
{ 
            
            #line default
            #line hidden
            this.Write("\t\t\t\tcase Field.Language");
            
            #line 38 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"

		if(s) {
            
            #line default
            #line hidden
            this.Write(" | Field.Script");
            
            #line 39 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(r) {
            
            #line default
            #line hidden
            this.Write(" | Field.Region");
            
            #line 40 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(v) {
            
            #line default
            #line hidden
            this.Write(" | Field.Variants");
            
            #line 41 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(e) {
            
            #line default
            #line hidden
            this.Write(" | Field.Extensions");
            
            #line 42 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(p) {
            
            #line default
            #line hidden
            this.Write(" | Field.PrivateUse");
            
            #line 43 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 } 
            
            #line default
            #line hidden
            this.Write(":\n");
            
            #line 44 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 if (s && r && v && e && p) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\tthrow new ApplicationException(\"This should never happen\");\n");
            
            #line 46 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\treturn new LanguageTag(Language");
            
            #line 47 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"

		if(s) {
            
            #line default
            #line hidden
            this.Write(", Script");
            
            #line 48 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(r) {
            
            #line default
            #line hidden
            this.Write(", Region");
            
            #line 49 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(v) {
            
            #line default
            #line hidden
            this.Write(", Variants");
            
            #line 50 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(e) {
            
            #line default
            #line hidden
            this.Write(", Extensions");
            
            #line 51 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 };
		if(p) {
            
            #line default
            #line hidden
            this.Write(", PrivateUse");
            
            #line 52 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 } 
            
            #line default
            #line hidden
            this.Write(");\n");
            
            #line 53 "/home/tolik/Repos/NLanguageTag/RegistryToSource/LanguageTag_Take.tt"
 } } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\tcase Field.PrivateUse:\n\t\t\t\t\treturn new LanguageTag(PrivateUse);\n\t\t\t\tdefault:\n\t\t\t\t\treturn new LanguageTag();\n\t\t\t}\n\t\t}\n\t}\n}\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class LanguageTag_TakeBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
