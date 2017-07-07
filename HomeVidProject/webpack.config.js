var webpack = require('webpack')


var path = require('path')

module.exports = {

	performance: { hints: false },


	entry: { 


		app: './scripts/src/assets/js/app.js',

		vendor: ['vue', 'axios', 'vue-resource', 'jquery', 'lodash']

	},


	output: {

		path: path.resolve(__dirname, './Scripts/built'),
		
		filename: '[name].js',

		publicPath: './Scripts/built'
	},


	module: {

		rules: [

		{
			test: /\.js$/,

			exclude: /node_modules/,

			loader: 'babel-loader'
		},

		{
			test: /\.vue$/,

			loader: 'vue-loader',

			options: {

			}
		},

		{
			test: /\.s[a|c]ss$/,			
			loader: ['sass-loader', 'style', 'css', 'sass']
		}

		]
	},


	resolve: {

		alias: {

			"vue": "vue/dist/vue.common"
		}

	},


	plugins: [

	new webpack.optimize.CommonsChunkPlugin({

		names: ['vendor']
	})	

	]


}


if (process.env.NODE_ENV === 'production') {

	new webpack.optimize.UglifyJsPlugin({

		sourcemap: true,

		compress: {

			warning: false
		}
	});


	module.exports.plugins.push(

		new webpack.DefinePlugin({

			'process.env': {

				NODE_ENV: 'production'
			}
		})
		);
}

// set NODE_ENV=production -- example


