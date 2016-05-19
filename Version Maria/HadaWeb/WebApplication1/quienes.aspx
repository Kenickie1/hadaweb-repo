<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="quienes.aspx.cs" Inherits="WebApplication1.quienes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p></p>
            <div id="page" class="container">
                <div class="row">

                    <!-- Content -->
                    <div id="content" align="justify" class="8u skel-cell-important">
                        <section>
                            <header class="major">
                                <h2>Quiénes Somos</h2>
                            </header>
                            <p>
                                <strong>Servirent</strong> nace en 2016 como una empresa de venta de <i>Servicios</i>, nuestro objetivo es hacer llegar al máximo número de personas
                                nuestra filosofia de <i>aprender de forma didáctica</i>, la mejor forma de aprender en los más pequeños.
                            </p>
                            <p>Somos una empresa joven tanto en cuanto al tiempo que llevamos en el mundo empresarial como a nuestros empleados.</p>
                            <p>Esperamos serle de utilidad, ¡cualquier duda no duden en escribirnos!</p>
                        </section>
                    </div>

                    <!-- Sidebar -->
                    <div id="sidebar" class="4u">
                        <section></section>
                        <section></section>
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
				<!-- /Main --> 

	</div>

	<!-- Footer -->
		<div id="footer" class="wrapper style2">
			<div class="container">
				<section>
					<header class="major">
						<h2>¿Tienes alguna pregunta?</h2>
						<span class="byline">¡No dudes en contactar con nosotros!</span>
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
								<textarea name="mensaje" id="message" placeholder="Mensaje"></textarea>
							</div>
						</div>
						<div class="row half">
							<div class="12u">
								<ul class="actions">
									<li>
										<input type="submit" value="Enviar Mensaje" class="button alt" />
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
