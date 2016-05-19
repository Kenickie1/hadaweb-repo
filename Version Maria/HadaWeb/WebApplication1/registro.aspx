<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="WebApplication1.registro" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Registro</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
							<div class="row no-collapse-1">
                            <p></p>
                            <style>
                            .box-white {
                            margin:20 20 20px;
                            overflow:hidden;
                            padding:30px;
                            background: white;
                            -webkit-border-radius: 100px;
                            border-radius: 5px;
                            }</style>
                            <p></p><p></p>
                            <div align="center">
                            <img src="images/avatar.png" alt="" />
                            <p></p>
                            <form enctype="multipart/form-data" action="" method="POST">
                            <input class="button nopopup" type="file" name="uploadedfile" value="Seleccione imagen"/>
                            </form>

                            <p></p>
                            </div>
                            <p></p>
                            <div class="box-white">
                            <fieldset class="box">
                            
								<ul align="left"><h2>MIS DATOS</h2><p></p>
                                <hr size="4px" width="100%" align="center" color="gray"/>
                                    <asp:Label ID="Error" runat="server" Text="" ForeColor ="Red"></asp:Label>
									<li>
										<span><strong>Género</strong> <em></em></span>
										<div class="cf">
											<label>
												<input type="radio" id="tqa_register_personTitleMr" name="personTitle" value="Mr"  /> Hombre
											</label>
											<label>
												<input type="radio" id="tqa_register_personTitleMrs" name="personTitle" value="Mrs"  /> Mujer
											</label>
										</div>
									</li><p></p><li>
										<label><strong>Nick</strong><em>*</em></label>
                                        <asp:TextBox ID="Nick" runat="server" required> </asp:TextBox>
                                        <asp:CustomValidator  ID="CustomValidatorNick"  
                                            ControlToValidate = "Nick" 
                                            OnServerValidate="ComprobarUsuario" runat="server"          
                                            ErrorMessage="Este nick ya existe"
                                            ForeColor ="Red">         
                                        </asp:CustomValidator>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularNick" runat="server" 
                                            ErrorMessage="El nick tiene que tener de 4 a 10 caracteres y solo puede contener letras y números"
                                            ControlToValidate="Nick"
                                            ValidationExpression="[\w]{4,10}"
                                            ForeColor ="Red">
                                        </asp:RegularExpressionValidator>
									</li><li>
										<label><strong>Nombre completo</strong><em>*</em></label>
                                        <asp:TextBox ID="Name" runat="server" Color ="blue" required> </asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularNombre" runat="server" 
                                            ErrorMessage="El nombre tiene que tener 20 caracteres como máximo y ser: Nombre Apellido1 Apellido2 (no admite acentos)"
                                            ControlToValidate="Name"
                                            ValidationExpression="[a-zA-Z]\w{1,20}\s[a-zA-Z]\w{1,20}\s[a-zA-Z]\w{1,20}"
                                            ForeColor ="Red">
                                        </asp:RegularExpressionValidator>
                                        
									</li><li>
										<label><strong>Dirección de E-mail</strong><em>*</em></label>
                                        <asp:TextBox ID="Email" runat="server" required > </asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularEmail" runat="server" 
                                            ErrorMessage="Escribe una dirección de correo valida"
                                            ControlToValidate="Email"
                                            ValidationExpression="\S+@\S+\.\S+"
                                            ForeColor ="Red">
                                        </asp:RegularExpressionValidator>
									</li><li class="password">
										<label><strong>Contraseña</strong><em>*</em></label>
                                        <asp:TextBox ID="Contrasenya" runat="server" required > </asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularContraseya" runat="server" required  
                                            ErrorMessage="La contraseña debe tener entre 4 y 20 valores y no puede contener espacios en blanco"
                                            ControlToValidate="Contrasenya"
                                            ValidationExpression="\S{4,20}"
                                            ForeColor ="Red">
                                        </asp:RegularExpressionValidator>
									</li><li class="password-repeat">
										<label><strong>Repite tu contraseña</strong><em>*</em></label>
                                        <asp:TextBox ID="RepiteContrasenya" runat="server" required> </asp:TextBox>
                                        <asp:CompareValidator ID="ComparaContrasenya" runat="server" 
                                            ErrorMessage="Las contraseñas no coinciden"
                                            ControlToValidate="RepiteContrasenya"
                                            ControlToCompare="Contrasenya"
                                            Operator="Equal"
                                            ForeColor ="Red">
                                        </asp:CompareValidator>
									</li><li class="fecha_nacimiento">
										<label><strong>Introduce tu fecha de nacimiento</strong><em>*</em></label>
                                        <asp:Label ID="Dia" runat="server" Text=" Día: "></asp:Label>
                                            <asp:DropDownList ID="DesplegableDia" runat="server">
                                            </asp:DropDownList>
                                        <asp:Label ID="Mes" runat="server" Text=" Mes: "></asp:Label>
                                       <asp:DropDownList ID="DesplegableMes" runat="server">
                                                <asp:ListItem Value="01">Enero</asp:ListItem>
                                                <asp:ListItem Value="02">Febrero</asp:ListItem>
                                                <asp:ListItem Value="03">Marzo</asp:ListItem>
                                                <asp:ListItem Value="04">Abril</asp:ListItem>
                                                <asp:ListItem Value="05">Mayo</asp:ListItem>
                                                <asp:ListItem Value="06">Junio</asp:ListItem>
                                                <asp:ListItem Value="07">Julio</asp:ListItem>
                                                <asp:ListItem Value="08">Agost</asp:ListItem>
                                                <asp:ListItem Value="09">Septiembre</asp:ListItem>
                                                <asp:ListItem Value="10">Octubre</asp:ListItem>
                                                <asp:ListItem Value="11">Noviembre</asp:ListItem>
                                                <asp:ListItem Value="12">Diciembre</asp:ListItem>
                                            </asp:DropDownList>
                                        <asp:Label ID="Ano" runat="server" Text=" Año: "></asp:Label>
                                        <asp:DropDownList ID="DesplegableAno" runat="server"></asp:DropDownList>
									</li><li class="Telefon">
                                        <br />
                                        <br />
										<label><strong>Introduce tu telefono</strong><em>*</em></label>
                                        <asp:TextBox ID="Telefono" runat="server"> </asp:TextBox>
									</li>
                                    <asp:RegularExpressionValidator ID="RegularTelefono" runat="server" 
                                        ControlToValidate="Telefono"
                                        ErrorMessage="Introduce un número de teléfono válido"
                                        ValidationExpression="\d{9}"
                                        ForeColor ="Red"></asp:RegularExpressionValidator>
									<li class="newsletter cf with-newsletter-type">
										<p></p>
										<label for="register-newsletter"><input class="inp-checkbox" type="checkbox" name="isNewsletterAtRegistrationActive" value="true"  id="register-newsletter"> Quiero recibir las últimas novedades y promociones de Servirent.</label>
										<p></p>

<li class="loyaltyClub loyaltyCheckbox permisions custom-place" data-place="#permisions-check-error">
	<input name="loyaltyTermsAndConditions" type="checkbox" id="loyaltyTermsAndConditions" value="true"/>
	<label  for="permisions-check">I accept the <a href="#" data-layer="example"> terms </a> and the <a href="#" data-layer="example"> privacy policy </a> of Club member.</label>
	<div id="permisions-check-error"></div>
</li>
								</ul>
								<p align="left" class="required">Los campos marcados con asterisco ( <em>*</em> ) son obligatorios.</p>
                                <asp:Button ID="Registrarse" runat="server" Text="Registrarse" OnClick="Registrar"> </asp:Button>

							</fieldset></div>

             <p></p>
                           
						</div> <p></p> <div><hr size="4px" width="100%" align="center" color="white"/></div>
					</div>
			</div>

								<!-- Main -->
					<div align="justify" id="main">
						<div class="container">
							<div class="row"> 
								
								<!-- Content -->
								<div class="6u">
									<section>
										<ul class="style">
											<li class="fa fa-question-circle">
												<h3><a href="quienes.aspx">Quiénes somos</a></h3>
												<span>Descubre a los creadores de esta website.</span> </li>
											<li class="fa fa-shopping-cart">
												<h3><a href="comocomprar.aspx">Cómo comprar</a></h3>
												<span>¿Dudas de como comprar? ¡Aquí te enseñamos como!</span> </li>
										</ul>
									</section>
								</div>
								<div class="6u">
									<section>
										<ul class="style">
											<li class="fa fa-mobile-phone">
												<h3><a href="contacto.aspx">Aviso legal y privacidad</a></h3>
												<span>Infórmate sobre nuestro aviso legal y la privacidad de nuestra web.</span> </li>
											<li class="fa fa-star">
												<h3><a href="ofertas.aspx">Ofertas</a></h3>
												<span>¿Buscas ofertas?¡Aquí encontrarás los mejores packs!</span> </li>
										</ul>
									</section>
								</div>
							</div>
						</div>
					</div>

	</div>

	<!-- Footer -->
		<div id="footer" class="wrapper style2">
			<div class="container">
				<section>
					<header class="major">
						<h2>¿Tienes alguna pregunta?</h2>
						<span class="byline">¡No lo dudes y contacta con nosotros!</span>
					</header>
					<form >
						<div class="row half">
							<div class="12u">
								<input class="text" type="text" name="name" id="name" placeholder="Nombre" />
							</div>
						</div>
						<div class="row half">
							<div class="12u">
								<input class="text" type="text" name="email" id="email" placeholder="Email" />
							</div>
						</div>
						<div class="row half">
							<div class="12u">
								<textarea name="message" id="message" placeholder="Mensaje"></textarea>
							</div>
						</div>
						<div class="row half">
							<div class="12u">
								<ul class="actions">
									<li>
										<input type="submit" value="Enviar mensaje" class="button alt" />
									</li>
								</ul>
							</div>
						</div>
					</form>
				</section>
			</div>
		</div>

	<!-- Copyright -->
		<div id="copyright">
			<div class="container">
				<div class="copyright">
					<p>Diseñado por Hada team </p>
				        <ul class="icons">
					        <li><a href="https://www.facebook.com/Serv1rent/"   target="_blank" class="fa fa-facebook"><span>Facebook</span></a></li>
					        <li><a href="https://twitter.com/Serv1rent"   target="_blank" class="fa fa-twitter"><span>Twitter</span></a></li>
					        <li><a href="https://www.instagram.com/servirent/"  target="_blank"  class="fa fa-instagram"><span>Instagram</span></a></li>
					        <li><a href="https://plus.google.com/u/0/104476755668848707232?hl=es"  target="_blank" class="fa fa-google-plus"><span>Google+</span></a></li>
				        </ul>
				</div>
			</div>
		</div>
</asp:Content>
