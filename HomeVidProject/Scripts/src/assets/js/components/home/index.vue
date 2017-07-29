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
			goHome(){
				this.$router.push('/');
			},

			getUser () {

				console.log('get user method call');
			}

		},

		watch: {
			'$route' (to, from){
				//alert(to.params.id);
				console.log(from)
				console.log(to)
			}
		},

		computed: {

		}

	}

</script>


<template>

	<div>
   

</div>



</template>


<style>
	.side-list ul li a span i {
		color: #FDFAFA !important;
	}
</style>