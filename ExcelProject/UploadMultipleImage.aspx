<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadMultipleImage.aspx.cs" Inherits="ExcelProject.UploadMultipleImage" %>
<html >
<head runat="server">
    <title>Multiple file Upload</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />  
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />  
    <%--
    <script src="http://jquery-multifile-plugin.googlecode.com/svn/trunk/jquery.js" type="text/javascript"></script>
    <script src="http://jquery-multifile-plugin.googlecode.com/svn/trunk/jquery.MultiFile.js" type="text/javascript"></script>
   --%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUploadJquery" runat="server" class="multi" accept="jpg|png" AllowMultiple="true" />
            <asp:Button runat="server" Text ="Upload File" OnClick ="btnUpload_Click" Class ="btn btn-sm btn-info" />

            <asp:Label ID="lblMessage" runat="server"></asp:Label>  
        </div>
    </form>
</body>
</html>