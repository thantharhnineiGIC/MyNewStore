#pragma checksum "C:\Users\GICM\Desktop\C#\TestingProjects\MyNewStore\MyNewStore\Pages\Clients\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63395b21319c500ee7c1b4b7a5691cba0623952c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyNewStore.Pages.Clients.Pages_Clients_Delete), @"mvc.1.0.razor-page", @"/Pages/Clients/Delete.cshtml")]
namespace MyNewStore.Pages.Clients
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\GICM\Desktop\C#\TestingProjects\MyNewStore\MyNewStore\Pages\_ViewImports.cshtml"
using MyNewStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GICM\Desktop\C#\TestingProjects\MyNewStore\MyNewStore\Pages\Clients\Delete.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63395b21319c500ee7c1b4b7a5691cba0623952c", @"/Pages/Clients/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e75084eca2453b44b9f5dbbb1edfc455f23e239", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\GICM\Desktop\C#\TestingProjects\MyNewStore\MyNewStore\Pages\Clients\Delete.cshtml"
  
    try
    {
        String id = Request.Query["id"];

        String connectionString = "Data Source=DESKTOP-TQS1JN3\\SQLEXPRESS;Initial Catalog=mystore;Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            String sql = "DELETE FROM clients WHERE id=@id";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
    }

    Response.Redirect("/Clients/Index");

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Clients_Delete> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Clients_Delete> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Clients_Delete>)PageContext?.ViewData;
        public Pages_Clients_Delete Model => ViewData.Model;
    }
}
#pragma warning restore 1591
