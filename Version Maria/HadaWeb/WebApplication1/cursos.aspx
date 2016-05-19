<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="cursos.aspx.cs" Inherits="WebApplication1.cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="extra">
						<div class="container">
                        <strong>Selecciona una categoría:</strong>
                        <select name="OS">
                           <option value="1">Estudios</option> 
                           <option value="2">Cocina</option> 
                           <option value="3">Ocio y cultura</option>
                           <option value="10">Deportes</option> 
                           <option value="11">Gabinete psicológico</option> 
                           <option value="12">Otros</option> 
                        </select>

                            <ul class="style">
								<h3>Cursos</h3>
                                <hr size="4px" width="100%" align="center" color="white"/>
							</ul>
                            
							<div class="row no-collapse-1">
								<section class="4u"> <a href="#" class="image featured"><img src="images/imagen01.jpg" alt=""></a>
									<div class="box">
										<a href="curso-ajedrez.aspx" class="button">Ajedrez</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/imagen02.jpg" alt=""></a>
									<div class="box">
										<a href="curso-photoshop.aspx" class="button">Photoshop</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/imagen03.jpg" alt=""></a>
									<div class="box">
										<a href="curso-balonmano.aspx" class="button">Balonmano</a> </div>
								</section>
							</div>
							<div class="row no-collapse-1">
								<section class="4u"> <a href="#" class="image featured"><img src="images/imagen04.jpg" alt=""></a>
									<div class="box">
										<a href="curso-natacion.aspx" class="button">Natación</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/imagen05.jpg" alt=""></a>
									<div class="box">
										<a href="curso-buceo.aspx" class="button">Buceo</a> </div>
								</section>
								<section class="4u"> <a href="#" class="image featured"><img src="images/imagen06.jpg" alt=""></a>
									<div class="box">
										<a href="curso-matematicas.aspx" class="button">Matemáticas</a> </div>
								</section>
                                <section class="4u"> <a href="#" class="image featured"><img src="images/imagen07.jpg" alt=""></a>
									<div class="box">
										<a href="curso-biologia.aspx" class="button">Biología</a> </div>
								</section>
                       			<section class="4u"> <a href="#" class="image featured"><img src="images/imagen08.jpg" alt=""></a>
									<div class="box">
										<a href="curso-fotografia.aspx" class="button">Fotografía</a> </div>
								</section>
                                <section class="4u"> <a href="#" class="image featured"><img src="images/imagen09.jpg" alt=""></a>
									<div class="box">
										<a href="curso-quimica.aspx" class="button">Química</a> </div>
								</section>
                                <section class="4u"> <a href="#" class="image featured"><img src="images/imagen10.jpg" alt=""></a>
									<div class="box">
										<a href="curso-badminton.aspx" class="button">Bádminton</a> </div>
								</section>
                				<section class="4u"> <a href="#" class="image featured"><img src="images/imagen11.jpg" alt=""></a>
									<div class="box">
										<a href="curso-fisica.aspx" class="button">Física</a> </div>
								</section>
                                <section class="4u"> <a href="#" class="image featured"><img src="images/imagen12.jpg" alt=""></a>
									<div class="box">
										<a href="curso-damas.aspx" class="button">Damas</a> </div>
								</section>
							</div>
                            <p></p>
                            <hr size="4px" width="100%" align="center" color="white"/>
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
