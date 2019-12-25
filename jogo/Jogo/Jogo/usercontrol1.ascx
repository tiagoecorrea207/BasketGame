<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usercontrol1.ascx.cs" Inherits="Jogo.WebUserControl1" %>
<!DOCTYPE html>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>

<style type="text/css">

.d1
{
width:100%;
height:35px;
background-color: #006435;  
}

.samp
{
width:100%;
margin:auto;   
}

.samp ul
{
padding:0px;
margin:0px; 
}
.samp ul li
{
    width:145px;
    float:left;
    display:inline-block;    
}

.samp ul li a
{
    font-family:Arial;
    font-size:15px;
    color:white;
    text-decoration:none;
    padding: 6px 10px 5px 15px;
    display: block;       
}

.samp ul li a:hover 
{
    background-color:#ffab45;  
    color:white; 
}
</style>
</head>
<body>

   <div class="d1">

<div class="samp">
	<ul>
	<li><A id="menu04" title="Fazer Pedidos" href="frm1.aspx">Fazer Pedidos</A></li>
	<li><A id="menu05" title="Meus Pedidos" href="frm2.aspx">Meus Pedidos</A></li>
	</ul>
</div>
</div>

</body>
</html>