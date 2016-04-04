<%@ Application Language="C#" %>

<script runat="server">

    static string _pagePath;

    void Application_BeginRequest(object sender, EventArgs e)
    {
        HttpContext context = HttpContext.Current;
        context.RewritePath("~/Index.cshtml");
    }

</script>