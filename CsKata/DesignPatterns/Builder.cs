using System.Collections.Generic;
using System.Text;

namespace CsKata.DesignPatterns
{
    public class Builder
    {
        public class CodeElement
        {
            public string Name, Type;
            public List<CodeElement> ChildElements = new List<CodeElement>();
            private const int indentSize = 2;

            public CodeElement()
            {
            }

            public CodeElement(string name, string type)
            {
                Name = name;
                Type = type;
            }

            private string ToStringImpl(int indent)
            {
                var sb = new StringBuilder();
                var i = new string(' ', indentSize * indent);
                sb.Append($"{i}public {Type} {Name}");
                if (indent > 0)
                    sb.Append(';');

                sb.AppendLine();
                if (indent == 0)
                    sb.AppendLine("{");

                foreach (var e in ChildElements)
                    sb.Append(e.ToStringImpl(indent + 1));

                if (indent == 0)
                    sb.AppendLine("}");

                return sb.ToString();
            }

            public override string ToString()
            {
                return ToStringImpl(0);
            }
        }

        public class CodeBuilder
        {
            private readonly string rootName;
            CodeElement root = new CodeElement();

            public CodeBuilder(string rootName)
            {
                this.rootName = rootName;
                root.Name = rootName;
                root.Type = "class";
            }

            public CodeBuilder AddField(string childName, string childType)
            {
                var e = new CodeElement(childName, childType);
                root.ChildElements.Add(e);
                return this;
            }

            public override string ToString()
            {
                return root.ToString();
            }
        }
    }
}