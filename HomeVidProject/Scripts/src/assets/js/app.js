/* global $ */

/***
 *	Load dependences*
 */
require('./bootstrap');


/**
 * New up components
 */
Vue.component('home-page', require('./components/home/home.vue'));
Vue.component('customer-home', require('./components/customer/customers-index.vue'));
Vue.component('customer-create-edit', require('./components/customer/customer-create-edit.vue'));
//Vue.component('sidebar', require('./components/Sidebar.vue'));

import Home from './components/home/home.vue';
import Customers from './components/customer/customers-index.vue';


window.eventBroadcaster = new Vue();


//window.papa_config = {
//    delimiter: ",", // auto-detect
//    newline: "", // auto-detect
//    quoteChar: '"',
//    header: false,
//    dynamicTyping: false,
//    preview: 0,
//    encoding: "",
//    worker: false,
//    comments: false,
//    step: undefined,
//    complete: undefined,
//    error: undefined,
//    download: false,
//    skipEmptyLines: false,
//    chunk: undefined,
//    fastMode: false,
//    beforeFirstChunk: undefined,
//    withCredentials: undefined
//}

const routes = [

    { path: '*', redirect: '/'},
    { path: '/', component: Home },
    { path: '/Home', component: Home },
    { path: '/customers/random', component: Customers },
    { path: '/customers/:id', component: Customers },
]

const router = new VueRouter({
    routes
});



var app = Vue.extend({});

const apps = new Vue({
    el: "#app",
    mode: 'history',
    router,

    mounted() {
        this.$nextTick(function () {


            //        //$.material.init();
            //        //$.material.ripples();
            //        //$.material.input();
            //        //$.material.checkbox();

            //        //$('label.tree-toggler').click(function() {
            //        //    $(this).parent().children('ul.tree').toggle(300);
            //        //});

            //        // $('select').selectize({
            //        // 	placeholder: 'Select a month',
            //        // 	// sortField: 'asc',
            //        // 	create: true,				
            //        // });


            ////Tooltip popups
            //        //$(".top").tooltip({
            //        //    placement: "top"
            //        //});

            //        //$(".right").tooltip({
            //        //    placement: "right"
            //        //});

            //        //$(".bottom").tooltip({
            //        //    placement: "bottom"
            //        //});

            //        //$(".left").tooltip({
            //        //    placement: "left"
            //        //});




        });
    }
});

