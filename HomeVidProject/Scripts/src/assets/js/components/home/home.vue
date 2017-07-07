<script>

	export default {

		

		data () {

			return {
				loggedinUser: {},
				welcome: 'HOMEVidEo Project Wango!',

			}
		},

		mounted () {

			this.$nextTick( function() {			    			
				this.getUser();
			})

		},


		methods: {

			getUser () {

				console.log('get user method call');
			}

		},


		computed: {

		}

	}

</script>


<template>

	<div>
		

		<div class="jumbotron">
			<h1>{{welcome}}</h1>
			<p class="lead">HomeVid Project NET</p>
			<p>
				<a href="#" class="btn btn-primary btn-lg">Learn more &raquo;</a>
			</p>
		</div>



		<div class="row">
			<div class="col-md-4">
				<h2>Watching</h2>                

				<p>
					lorem 
				</p>
				<p><a class="btn btn-default" href="#">Learn more &raquo;</a></p>
			</div>
			<div class="col-md-4">
				<h2>Recommended</h2>
				<p>update libraries</p>
				<p><a class="btn btn-default" href="#">Learn more &raquo;</a></p>
			</div>
			<div class="col-md-4">
				<h2>Most Popular</h2>
				<p>You can easily find</p>
				<p><a class="btn btn-default" href="#">Learn more &raquo;</a></p>
			</div>
		</div>


	</div>



</template>


<style>
	.side-list ul li a span i {
		color: #FDFAFA !important;
	}
</style>