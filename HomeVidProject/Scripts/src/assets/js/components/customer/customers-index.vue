<template>
    <div>


        <br />
        {{ $route.params.id }}

        <p v-if="customers.length <= 0">There are currently no customerDtoDtos!</p>

        <p>
            <!--<span><a href="/customers/New" class="btn btn-success btn-xs">Add New</a></span>-->
            <span><a @click="createCustomer" class="btn btn-success btn-xs">Add New</a></span>
        </p>

        <table class="table table-bordered table-hover">
            <thead>
                <tr>
                    <th>Customer</th>
                    <th>Membership Type</th>
                    <th>Action</th>

                </tr>
            </thead>
            <tbody>


                <tr v-for="customer in customers">
                    <td><a :href="'/api/customers/' + customer.id" class="btn-link">{{customer.name}}</a></td>
                    <td>{{customer.membershipType.membershipName}}</td>
                    <td><button @click="deleteCustomer(customer)" class="btn-link text-danger">Delete</button></td>
                </tr>


            </tbody>

        </table>



        <div class="modal fade" id="create-edit-customer" tabindex="-1" role="dialog" data-backdrop="static" data-keyboard="false">

            <div class="modal-dialog">

                <div class="modal-content">

                    <div class="modal-header">
                        <button type="button" class="close btn-danger" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h5 class="modal-title">New Customer</h5>
                    </div>

                    <div class="modal-body">

                        <form @submit.prevent="persistCustomer">


                            <div class="form-group">
                                <label for="name" class="">DoB</label>
                                <input type="text" id="name" v-model="customerForm.name" class="form-control input-sm" />


                            </div>

                            <div class="form-group">
                                <label for="membershipTypeId" class="">DoB</label>
                                <input type="text" id="membershipTypeId" v-model="customerForm.membershipTypeId" class="form-control input-sm" />

                            </div>

                            <div class="form-group">
                                <label for="customer_dob" class="">DoB</label>
                                <v-select :value.sync="selected" :options="options"></v-select>

                                <input type="text" id="customer_dob" v-model="customerForm.doB" class="form-control input-sm" placeholder="01/MM/yyyy" />
                            </div>



                            <div class="checkbox">
                                <label>
                                    <input v-model="customerForm.isSubscribedToNewsletter" class="checkbox" type="checkbox" /> Subscribe To Newsletter?
                                </label>
                            </div>

                            <button type="submit" class="btn btn-success btn-sm">Save</button>

                        </form>

                    </div>


                    <div class="modal-footer">

                        <button type="button" class="btn btn-xs btn-default" data-dismiss="modal">Close</button>

                    </div>

                </div>
            </div>
        </div>

    </div>
</template>


<script>

    import FormHelper from '../../mixins/FormHelper';
    import vSelect from "vue-select"

    export default {
        mixins: [FormHelper],
        components: {vSelect},
        data() {
            return {

                customers: {},
                selected: null,
                options: ['foo','bar','baz'],

                customerForm: new Form({
                    name: '',
                    membershipTypeId: '',
                    doB: '',
                    isSubscribedToNewsletter: '',                    

                }),
            }
        },

        mounted(){
            this.$nextTick(function(){
                this.getCustomers();               
                                                
            })
        },

    methods:{

        getCustomers() {
            axios.get("/api/customers")
                .then(response => {
                    this.customers = response.data
                })
                .catch(errors => {})
        },


        createCustomer(){
            $("#create-edit-customer").modal();
        },

        persistCustomer(){
            
            axios.post('/api/customers', this.customerForm)
                .then(response => {
                    console.log(response.data);
                })
                .catch(errors =>{});
        },

        editCustomer(customer) {
        
        },

        deleteCustomer(customer){

            axios.delete(`/api/customers/${customer.id}`)
                .then(response => {
                    
                    this.customers = _.reject(this.customers, (c) => { return c.id == customer.id });
                
                })
                .catch(error =>{})            
        }
    }
    }
</script>

