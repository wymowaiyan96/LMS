<%@ Page Title="" Language="C#" MasterPageFile="~/Libarian/Libarian.Master" AutoEventWireup="true" CodeBehind="addBooks.aspx.cs" Inherits="LMS.Libarian.addBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
      <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Add New Books</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  
                                 
                                  <form action="" id="fo1" runat="server" method="post" novalidate="novalidate">
                                    
                                      <div class="form-group">
                                          <label class="control-label mb-1">Books Title</label>
                                           <asp:TextBox ID="tbxBookTitle" runat="server" class="form-control"></asp:TextBox>
                                      </div>                                 
                                    
                                      <div class="form-group">
                                          <label class="control-label mb-1">Book Image</label>
                                         <asp:FileUpload ID="f1" runat="server"  class="form-control" />
                                      </div>    

                                      <div class="form-group">
                                          <label class="control-label mb-1">Book Author</label>
                                           <asp:TextBox ID="tbxAuthor" runat="server" class="form-control"></asp:TextBox>
                                      </div>    

                                      <div class="form-group">
                                          <label class="control-label mb-1">Book ISBN</label>
                                           <asp:TextBox ID="tbxISBN" runat="server" class="form-control"></asp:TextBox>
                                      </div>    

                                      <div class="form-group">
                                          <label class="control-label mb-1">Book Quantity</label>
                                           <asp:TextBox ID="tbxQty" runat="server" class="form-control"></asp:TextBox>
                                      </div>    
                                     
                                      <div>
                                        <asp:Button ID="btnPayment" runat="server" Text="Add" class="btn btn-lg btn-info btn-block" OnClick="btnPayment_Click" />
                                      </div>

                                           <div id="info" runat="server" class="alert alert-success"  style="margin-top:10px;display:none" >
                                                 <strong>The Book has been added!</strong>
                                             </div>

                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
