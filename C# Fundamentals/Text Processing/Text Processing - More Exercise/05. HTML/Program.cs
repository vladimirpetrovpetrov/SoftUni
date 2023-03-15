using System.Text;

var title = Console.ReadLine();
StringBuilder output = new StringBuilder();
Header(output,title!);

var content = Console.ReadLine();
Content(output,content!);
while (true)
{
    var comment = Console.ReadLine();
    if(comment == "end of comments")
    {
        break;
    }
    Comment(output, comment!);
}
Console.WriteLine(output.ToString());
static void Header(StringBuilder st,string header)
{
    st.AppendLine("<h1>");
    st.AppendLine("    " + header);
    st.AppendLine("</h1>");
}
static void Content(StringBuilder st, string content)
{
    st.AppendLine("<article>");
    st.AppendLine("    " + content);
    st.AppendLine("</article>");
}
static void Comment(StringBuilder st,string comment)
{
    st.AppendLine("<div>");
    st.AppendLine("    " + comment);
    st.AppendLine("</div>");
}