<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="comprar.aspx.cs" Inherits="WebApplication1.comprar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p></p>
					<div id="page" class="container">
						<div class="row">

							<!-- Sidebar -->
							<div id="sidebar" class="4u">
								<section>
									<header class="major">
										<img src="img/carrito01.png">
									</header>
									<div class="row half">
										
											<ul class="icons">
				</ul>
										
									
									</div>
								</section>
								
							</div>
							
							<!-- Content -->
							<div id="content" align="justify" class="8u skel-cell-important">
								<section>
									<header class="major">
										<h2>Cómo comprar</h2>
									</header>
                                    <p> 1) Comprar en Servirent es muy sencillo. Para registrarte en nuestra web debes hacer clic en el botón "Identifícate" que encontrarás en la parte superior derecha. Una vez creada tu cuenta podrás hacer todos los pedidos que desees sin tener que introducir los datos cada vez. Además, en tu panel tendrás acceso a tus facturas, a la tramitación de incidencias, devoluciones, atención al cliente...

<br /><br />2) Una vez seleccionados los productos debes hacer clic en "realizar pedido" y elegir la forma de pago y el tipo de envío. En todo momento estarás informado del precio total de tu compra y los gastos de transporte.

<br /><br />3) Por último te mostraremos un resumen de tu pedido. La compra se formalizará pulsando el botón "Finalizar compra". En ese momento te enviaremos un correo electrónico con todos los datos de tu pedido. Una vez salga de nuestras instalaciones te informaremos por correo electrónico y sms y podrás hacer seguimiento en todo momento.

Cualquier duda que tenga no dude en contactarnos

¡ Comprar en nuestra web es muy fácil !</p>
									</section>
							</div>
		
						</div>
					</div>
				<!-- /Page -->

				<!-- Main -->
					<div id="main">
						<div class="container">
							<div class="row"> 
								
								<!-- Content -->
								<div class="6u">
									<section>
										<ul class="style">
											<li class="fa fa-wrench">
												<h3>Soporte</h3>
												<span>En Servirent ofrecemos diferentes formas de obtener la asistencia de soporte técnico que usted necesita, así como la ayuda para cualquier duda que tenga.
												Si usted necesita ayuda de como crear su cuenta, o bien su realizar o cancelar una reserva, puede abrir un caso técnico (ticket), en donde por medio del mismo caso le informaremos y le ayudaremos en todo lo que necesite.
												</br><a href="avisolegal.aspx">Soporte técnico</a>
												</span> </li>
												
											<li class="fa fa-leaf">
												<h3>Aviso Legal</h3>
												<span><b>1. DATOS IDENTIFICATIVOS</b></br>
                                                En cumplimiento con el deber de información recogido en artículo 10 de la Ley 34/2002, de 11 de julio, de Servicios de la Sociedad de la Información y del Comercio Electrónico, a continuación se reflejan los siguientes datos: la empresa titular de dominio web es Servirent, con domicilio ...
                                                </br><a href="avisolegal.aspx">Aviso legal</a>
                                                </span> </li>
										</ul>
									</section>
								</div>
								<div class="6u">
									<section>
										<ul class="style">
											<li class="fa fa-cogs">
												<h3>Privacidad</h3>
												<span>Este aviso de Privacidad forma parte del uso del sitio web www.servirent.com.

                                                </br><b>RESPONSABLE</b></br>
                                                Servirent es una pagina destinada a la venta de servicios en internet, estamos ubicados en Carretera San Vicente del Raspeig s/n, 03690 San Vicente del Raspeig - Alicante Tel. 96 590 3400 - Fax 96 590 3464...
                                                </br><a href="Privacidad.aspx">Privacidad</a></span>
												<li class="fa fa-road">
												<h3>Trabaja con nosotros</h3>
												<span>Si desea trabajar con nosotros, por favor, pinche en este enlace y sera redireccionado a nuestro formulario.
												</br><a href="trabaja.aspx">Formulario</a></span> </li>
										</ul>
									</section>
								</div>
							</div>
						</div>
					</div>
				<!-- /Main --> 

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
	<!-- /Footer -->

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
