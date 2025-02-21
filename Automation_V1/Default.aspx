<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Automation_V1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
   
         <div class="row">

                 <h2> Welcome to Thyme Contract Management</h2>



             <hr />

             </div>

        <div class="row">



            
             

    <div class="col-md-3">
      

                <div class="card" style="width: 18rem;">
  <img src="Images/building.jpg" class="card-img-top" alt="Company">
  <div class="card-body">
    <h5 class="card-title">Create Company</h5>
    <p class="card-text">This Link used to create the Company</p>
    <a href="createclient" class="btn custom-btn">Click Here</a>
  </div>
</div>

        </div>

                      <div class="col-md-3">
                
                             <div class="card" style="width: 18rem;">
  <img src="Images/Contract.jpg" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Create Contract</h5>
    <p class="card-text">This Link used to create the Contract</p>
    <a href="createContract" class="btn custom-btn">Click Here</a>
  </div>
</div>

</div>

                      <div class="col-md-3">
                
                <div class="card" style="width: 18rem;">
  <img src="images/agreement.jpg" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Approve Document</h5>
    <p class="card-text">This Link used to approve the pending Documents</p>
    <a href="ViewApprove" class="btn custom-btn">Click Here</a>
  </div>
</div>
</div>
                

            
                      <div class="col-md-3">
                
                <div class="card" style="width: 18rem;">
  <img src="images/agreement.jpg" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Reports</h5>
    <p class="card-text">This Link has customised Report designed</p>
    <a href="" class="btn custom-btn">Click Here</a>
  </div>
</div>
</div>

         
        </div>

           
    </main>

</asp:Content>
