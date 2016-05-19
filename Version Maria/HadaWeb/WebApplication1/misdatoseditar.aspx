<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="misdatoseditar.aspx.cs" Inherits="WebApplication1.misdatoseditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                            <ul class="style">
								<h3>Editar mis datos</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
							<div class="row no-collapse-1">
                            <p></p><p></p><p></p><p></p>
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
                            <div align="center">                            <img src="images/avatar.png" alt="" />                            <p></p>                            <button class="button nopopup">Cambiar imagen</button>                            <p></p>                            </div>
                            <p></p>
                            <div class="box-white">
                            <fieldset class="box">
                            
								<ul align="left"><h2>MIS DATOS</h2><p></p>
                                <hr size="4px" width="100%" align="center" color="gray"/>
									<input type="hidden" name="accountType" value="private" />
									<li>
										<span><strong>Género</strong></span>
                                        <p>
										<label>
											<input type="radio" id="tqa_register_personTitleMr" name="personTitle" value="Mr"  /> Hombre
										</label>
										<label>
											<input type="radio" id="tqa_register_personTitleMrs" name="personTitle" value="Mrs"  /> Mujer
										</label></p>
									</li><p></p><li>
										<label><strong>Nick</strong></label>
										<input type="text" name="firstName" id="Text1" value="" maxLength="50" />
									</li><li>
										<label><strong>Nombre completo</strong></label>
										<input type="text" name="firstName" id="register-firstname" value="" maxLength="50" />
									</li><li>
										<label><strong>Dirección de E-mail</strong></label>
										<input type="text" name="email1" id="register-email"  value="" maxLength="100" />
									</li>
								</ul>
                                <button align="left" class="button nopopup">Confirmar cambios</button>

							</fieldset></div>             <p></p>
                           
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
												<h3><a href="avisolegal.aspx">Aviso legal y privacidad</a></h3>
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
					<form method="post" action="#">
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
