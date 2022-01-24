<%@ Page Title="" Language="C#" MasterPageFile="~/Hi1.Master" AutoEventWireup="true" CodeBehind="reservation.aspx.cs" Inherits="IceCream.reservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <div class="row">
         <div class="col-md-12">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Book Now</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="imgs/mrbaker.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr/>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Member ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Member ID"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Table No : <asp:Label ID="Label1" runat="server"></asp:Label>
                         </label>
                        &nbsp;<div class="form-group">
                           <div class="input-group">
                               <asp:RadioButtonList  ID="RadioButtonList1" runat="server" Visible="False">
                             
                              <asp:ListItem Text="Table1" Value="Table1" />
                              <asp:ListItem Text="Table2" Value="Table2" />
                              <asp:ListItem Text="Table3" Value="Table3" />
                              <asp:ListItem Text="Table4" Value="Table4" />
                              <asp:ListItem Text="Table5" Value="Table5" />
                              <asp:ListItem Text="Table6" Value="Table6" />
                              <asp:ListItem Text="Table7" Value="Table7" />
                              <asp:ListItem Text="Table8" Value="Table8" />
                              <asp:ListItem Text="Table9" Value="Table9" />
                              <asp:ListItem Text="Table10" Value="Table10" />
                          
                              </asp:RadioButtonList>
                           </div>
                        </div>
                         
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Member Name</label>
                        <div class="form-group">
                            
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Member Name" ></asp:TextBox>
                        </div>
                     </div>
                     
                      </div>
                     <div class="row">
                     <div class="col-md-6">
                        <label>Guest</label>
                        <div class="form-group">
                            
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Guest" ></asp:TextBox>
                        </div>
                     </div>

                         
                     <div class="col-md-6">
                        <label>Booking Date</label>
                        <div class="form-group">
                            <asp:Calendar  ID="Calendar1" runat="server"></asp:Calendar>

                        </div>
                     </div>
                         </div>
                 <div class="row">
                     <div class="col-md-6">
                        <label>Time in</label>
                        <div class="form-group">
                            <div class="input-group">
                           <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                                 <asp:ListItem Value="-1">Select Time to arrive at the restaurant</asp:ListItem>
                                <asp:ListItem Value="0">7:00 am</asp:ListItem>
                                <asp:ListItem Value="1">8:00 am</asp:ListItem>
                                <asp:ListItem Value="2">9:00 am</asp:ListItem>
                                <asp:ListItem Value="3">10:00 am</asp:ListItem>
                                <asp:ListItem Value="4">11:00 am</asp:ListItem>
                                <asp:ListItem Value="5">12:00 pm</asp:ListItem>
                                <asp:ListItem Value="6">01:00 pm</asp:ListItem>
                                <asp:ListItem Value="7">02:00 pm</asp:ListItem>
                                <asp:ListItem Value="8">03:00 pm</asp:ListItem>
                                <asp:ListItem Value="9">04:00 pm</asp:ListItem>
                                <asp:ListItem Value="10">05:00 pm</asp:ListItem>
                                <asp:ListItem Value="11">06:00 pm</asp:ListItem>
                                <asp:ListItem Value="12">07:00 pm</asp:ListItem>
                            </asp:DropDownList>
                                </div>
                        </div>
                     </div>
                 
                  
                     <div class="col-md-6">
                        <label>Time</label>
                        <div class="form-group">
                           <div class="input-group">
                           <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
                                 <asp:ListItem Value="-1">Select Time to leave the restaurant</asp:ListItem>
                                <asp:ListItem Value="0">7:00 am</asp:ListItem>
                                <asp:ListItem Value="1">8:00 am</asp:ListItem>
                                <asp:ListItem Value="2">9:00 am</asp:ListItem>
                                <asp:ListItem Value="3">10:00 am</asp:ListItem>
                                <asp:ListItem Value="4">11:00 am</asp:ListItem>
                                <asp:ListItem Value="5">12:00 pm</asp:ListItem>
                                <asp:ListItem Value="6">01:00 pm</asp:ListItem>
                                <asp:ListItem Value="7">02:00 pm</asp:ListItem>
                                <asp:ListItem Value="8">03:00 pm</asp:ListItem>
                                <asp:ListItem Value="9">04:00 pm</asp:ListItem>
                                <asp:ListItem Value="10">05:00 pm</asp:ListItem>
                                <asp:ListItem Value="11">06:00 pm</asp:ListItem>
                                <asp:ListItem Value="12">07:00 pm</asp:ListItem>
                            </asp:DropDownList>
                               </div>
                        </div>
                     </div>
                  </div>
                  
                
                  <div class="row">
                     <div class="col-6">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-primary" runat="server" Text="Book" OnClick="Button2_Click" />
                     </div>
                     <div class="col-6">
                        <asp:Button ID="Button4" class="btn btn-lg btn-block btn-success" runat="server" Text="Check" OnClick="Button4_Click" />
                     </div>
                  </div>
                <div class="row">
                    <div class="col-12">
              <label>Message<asp:Label ID="Label2" runat="server"></asp:Label>
                        </label>
                        &nbsp;<div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Message"></asp:TextBox>
                        </div>
                     </div>
               </div>
            </div>
             </div> 
             </div>
            
            <a href="home.aspx"><< Back to Home</a><br/>
            <br/>
        </div>
                  </div>
              
</asp:Content>
