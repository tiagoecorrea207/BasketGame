<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm1.aspx.cs" Inherits="Jogo.frm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js">></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="toggleDisplay">
        Registro de Pontos do Basquete
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="48px" Width="294px" onclick="Validate('RadioButtonList1')" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Lançar pontos</asp:ListItem>
            <asp:ListItem>Ver resultados</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="234px">
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            Data do jogo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantos pontos você fez:
            <asp:TextBox ID="TextBox1" runat="server" Width="156px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" style="margin-left: 0px" Text="Salvar" OnClick="Button1_Click" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="200px">
            Resultados&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="XX/XX/XXXX"></asp:Label>
            &nbsp;a
            <asp:Label ID="Label2" runat="server" Text="XX/XX/XXXX"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="XX/XX/XXXX"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="XX/XX/XXXX"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="XX/XX/XXXX"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="XX/XX/XXXX"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="XX/XX/XXXX"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="XX/XX/XXXX"></asp:Label>
        </asp:Panel>
    </form>
<script type="text/javascript">
    function Validate(rb) {
        var rb = document.getElementById('RadioButtonList1');
        var panel1 = document.getElementById('Panel1');
        var panel2 = document.getElementById('Panel2');

        var rblist = rb.getElementsByTagName("input");
        for (var i = 0; i < rblist.length; i++) {
            if (rblist[i].checked) {
                if (rblist[i].value == "Lançar pontos") {
                    panel1.style.display = "block";
                    panel2.style.display = "none";

                }
                else if (rblist[i].value == "Ver resultados") {
                    panel1.style.display = "none";
                    panel2.style.display = "block";
                }
            }
        }
    }
</script>
</body>
</html>
