<!-- section -->
	<div class="section">
		<!-- container -->
		<div class="container">
			<!-- row Laptop-->
			<div class="row">
				<!-- section title -->
				<div class="col-md-12">
					<div class="section-title">
						<h2 class="title">Laptop</h2>
					</div>
				</div>
				<!-- section title -->

				@foreach($laptop as $l)
					<div class="col-md-3 col-sm-6 col-xs-6">
						<div class="product product-single">
							<div class="product-thumb">
								<img src="./Gambar/Laptop/{{$l->gambar_barang}}" alt="">
							</div>
							<div class="product-body">
								<h3 class="product-price">Rp.{{$l->harga_jual_barang}}</h3>
								<h2 class="product-name"><a href="#">{{$l->nama_barang}}</a></h2>
								<div class="product-btns">
									<button class="primary-btn add-to-cart"><i class="fa fa-shopping-cart"></i> Add to Cart</button>
								</div>
							</div>
						</div>
					</div>
				@endforeach

			</div>
			<!-- row Kamera-->
			<div class="row">
				<!-- section title -->
				<div class="col-md-12">
					<div class="section-title">
						<h2 class="title">Kamera</h2>
					</div>
				</div>
				<!-- section title -->

				<!-- Product Single -->
				@foreach($kamera as $k)
				<div class="col-md-3 col-sm-6 col-xs-6">
					<div class="product product-single">
						<div class="product-thumb">
							<img src="./Gambar/Kamera/{{$k->gambar_barang}}" alt="">
						</div>
						<div class="product-body">
							<h3 class="product-price">Rp.{{$k->harga_jual_barang}}</h3>
							<h2 class="product-name"><a href="#">{{$k->nama_barang}}</a></h2>
							<div class="product-btns">
								<button class="primary-btn add-to-cart"><i class="fa fa-shopping-cart"></i> Add to Cart</button>
							</div>
						</div>
					</div>
				</div>
				@endforeach
				<!-- /Product Single -->
			</div>
			<!-- /row -->
			<!-- row Handphone-->
			<div class="row">
				<!-- section title -->
				<div class="col-md-12">
					<div class="section-title">
						<h2 class="title">Handphone</h2>
					</div>
				</div>
				<!-- section title -->

				<!-- Product Single -->
				@foreach($handphone as $hp)
				<div class="col-md-3 col-sm-6 col-xs-6">
					<div class="product product-single">
						<div class="product-thumb">
							<img src="./Gambar/Handphone/{{$hp->gambar_barang}}" alt="">
						</div>
						<div class="product-body">
							<h3 class="product-price">Rp.{{$hp->harga_jual_barang}}</h3>
							<h2 class="product-name"><a href="#">{{$hp->nama_barang}}</a></h2>
							<div class="product-btns">
								<button class="primary-btn add-to-cart"><i class="fa fa-shopping-cart"></i> Add to Cart</button>
							</div>
						</div>
					</div>
				</div>
				@endforeach
				<!-- /Product Single -->
			</div>
			<!-- /row -->
			<!-- row Tablet -->
			<div class="row">
				<!-- section title -->
				<div class="col-md-12">
					<div class="section-title">
						<h2 class="title">Tablet</h2>
					</div>
				</div>
				<!-- section title -->

				<!-- Product Single -->
				@foreach($tablet as $t)
				<div class="col-md-3 col-sm-6 col-xs-6">
					<div class="product product-single">
						<div class="product-thumb">
							<img src="./Gambar/Tablet/{{$t->gambar_barang}}" alt="">
						</div>
						<div class="product-body">
							<h3 class="product-price">Rp.{{$t->harga_jual_barang}}</h3>
							<h2 class="product-name"><a href="#">{{$t->nama_barang}}</a></h2>
							<div class="product-btns">
								<button class="primary-btn add-to-cart"><i class="fa fa-shopping-cart"></i> Add to Cart</button>
							</div>
						</div>
					</div>
				</div>
				@endforeach
				<!-- /Product Single -->
			</div>
			<!-- /row -->
			<!-- row Powerbank-->
			<div class="row">
				<!-- section title -->
				<div class="col-md-12">
					<div class="section-title">
						<h2 class="title">Powerbank</h2>
					</div>
				</div>
				<!-- section title -->

				<!-- Product Single -->
				@foreach($powerbank as $pb)
				<div class="col-md-3 col-sm-6 col-xs-6">
					<div class="product product-single">
						<div class="product-thumb">
							<img src="./Gambar/Powerbank/{{$pb->gambar_barang}}" alt="">
						</div>
						<div class="product-body">
							<h3 class="product-price">Rp.{{$pb->harga_jual_barang}}</h3>
							<h2 class="product-name"><a href="#">{{$pb->nama_barang}}</a></h2>
							<div class="product-btns">
								<button class="primary-btn add-to-cart"><i class="fa fa-shopping-cart"></i> Add to Cart</button>
							</div>
						</div>
					</div>
				</div>
				@endforeach
				<!-- /Product Single -->
			</div>
			<!-- /row -->	
		</div>
		<!-- /container -->
	</div>
	<!-- /section -->
