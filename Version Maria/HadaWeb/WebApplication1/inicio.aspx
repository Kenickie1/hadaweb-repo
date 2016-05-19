<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="WebApplication1.inicio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="banner" class="container">
						<section align=left>

                                <p align=left>
					            <img src="images/meditation.png" width="150" height="150"/><h0>SERVIRENT</h0> 
                              
						</section>
					</div>

				<!-- Extra -->
					<div id="extra"></p>
						<div class="container">
                        <ul class="style">
                            </p>
								<h3>Buscador</h3>
							</ul>
                            <hr size="4px" width="100%" align="center" color="white"/>
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <p></p>
                            <style>
                            .resaltar{background-color:#FF0;}
                            </style> 
                            <script type='text/javascript' >
                                $.expr[':'].icontains = function (obj, index, meta, stack) {
                                    return (obj.textContent || obj.innerText || jQuery(obj).text() || '').toLowerCase().indexOf(meta[3].toLowerCase()) >= 0;
                                };
                                $(document).ready(function () {
                                    $('#buscador').keyup(function () {
                                        buscar = $(this).val();
                                        $('#lista li').removeClass('resaltar');
                                        if (jQuery.trim(buscar) != '') {
                                            $("#lista li:icontains('" + buscar + "')").addClass('resaltar');
                                        }
                                    });
                                });
                             </script> 

                            <ul id="Ul2"><input name="buscador" id="Text2" type="text" placeholder="Buscar en toda la web" /><p></p>                              
                            <p ALIGN=right>
                            <a href="cursos.aspx" class="button small"><img src="img/lupa07.png"/></a>
                            </p>
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <hr size="4px" width="100%" align="center" color="white"/>

                            <p></p>
							<ul class="style">
								<h3>Cursos</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <p></p>
							<div class="row no-collapse-1">
								<section class="4u"> <a href="curso-ajedrez.aspx" class="image featured"><img src="images/imagen01.jpg" alt=""></a>
									<div class="box">
										<a href="curso-ajedrez.aspx" class="button">Ajedrez</a> </div>
								</section>
								<section class="4u"> <a href="curso-photoshop.aspx" class="image featured"><img src="images/imagen02.jpg" alt=""></a>
									<div class="box">
										<a href="curso-photoshop.aspx" class="button">Photoshop</a> </div>
								</section>
								<section class="4u"> <a href="curso-balonmano.aspx" class="image featured"><img src="images/imagen03.jpg" alt=""></a>
									<div class="box">
										<a href="curso-balonmano.aspx" class="button">Balonmano</a> </div>
								</section>
							</div>
                            <p></p>
                            <p ALIGN=right>
                                <a href="cursos.aspx" class="button medium">Ver más</a>
                                <hr size="4px" width="100%" align="center" color="white"/>
                            </p>
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            <p></p>
                            
							<ul class="style">
								<h3>Ofertas destacadas</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
                            
                            <!-- <img src="images/separador01.png" alt="" /> -->
                            
                            <p></p>
							<div class="row no-collapse-1">
								<section class="4u"> <a href="oferta-buceonatacion.aspx" class="image featured"><img src="images/pack01.png" alt=""></a>
									<div class="box">
										<a href="oferta-buceonatacion.aspx" class="button">Buceo + Natación</a> </div>
								</section>
								<section class="4u"> <a href="oferta-badminbalon.aspx" class="image featured"><img src="images/pack02.png" alt=""></a>
									<div class="box">
										<a href="oferta-badminbalon.aspx" class="button">Bádminton + Balonmano</a> </div>
								</section>
								<section class="4u"> <a href="oferta-matesfisica.aspx" class="image featured"><img src="images/pack03.png" alt=""></a>
									<div class="box">
										<a href="oferta-matesfisica.aspx" class="button">Matemáticas + Física</a> </div>
								</section>
							</div>
                            <p></p>
                           <p ALIGN=right>
                                <a href="ofertas.aspx" class="button medium">Ver más</a>
                                <hr size="4px" width="100%" align="center" color="white"/>
                            </p>
                            <!-- <img src="images/separador01.png" alt="" /> -->
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
