<%@ Page Title="" Language="C#" MasterPageFile="~/Hi1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="IceCream.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <section>
         <div class="container">
             <img src="imgs/5.jpg"  class="img-fluid"/>
              <div class="content">
    <h1>MR.Baker</h1>
    <p>Sweet Food,Happy Mood</p>
  </div>
</div>

         
   </section>
    <section>
        <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Our Specials</h2>
                  <p><b>Top Rated Dessert Of The Month</b></p>
               </center>
            </div>
         </div>
            </div>
        <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
    <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
      <div class="carousel-item active">
          
          <img src="imgs/slide03.jpg" class="d-block w-100" alt="..."/>
      <div class="carousel-caption d-none d-md-block">
        <h1>Blind Love</h1>
        <p>Made up of Ice Cream, Black Current Fruits,Black Current Flavouring Substances.</p>
      </div>
    </div>
    <div class="carousel-item">

        <img src="imgs/page-1_img09.jpg"  class="d-block w-100" alt="..."/>
      <div class="carousel-caption d-none d-md-block">
        <h1>Double Scoop</h1>
        <p>  Caramel ice cream with chocolate cookie crumb swirl and Swiss chocolate pieces.</p>
      </div>
    </div>
    <div class="carousel-item">

        <img src="imgs/pexels-photo-827516.jpeg"   class="d-block w-100" alt="..."/>
      <div class="carousel-caption d-none d-md-block">
        <h1>Valley Of Love</h1>
        <p>Red raspberry ice cream with fudge swirl and raspberry filled cordial bowls.</p>
      </div>
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
    </section>

    <section>
        <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Our Special Services</h2>
                  <p><b>Book Table Online </b></p>
               </center>
            </div>
         </div>
            </div>
<div class="contain">
        <img src="imgs/menu-restaurant-vintage-table.jpg"  class="img-fluid"/>
    <div class="text">
    <h1>Reservation</h1>
    <p>Click Here</p>
  </div>
</div>
   </section>

     <section>
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Our Purpose</h2>
                  <p><b>We Have A dream To See Everyone Happy</b></p>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/sign-up.png" />
                  <h4>Sign Up</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/menu.png" />
                  <h4>Menu Card</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150px" src="imgs/visitor.png" />
                  <h4>Visit Us</h4>
                  <p class="text-justify">Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor. reprehenderit</p>
               </center>
            </div>
         </div>
      </div>
   </section>

</asp:Content>
