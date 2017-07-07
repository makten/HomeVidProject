<script>
    export default {
        data() {
            return {
                customers: {}
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

        deleteCustomer(customer){
            console.log(customer);
            this.customers = _.reject(this.customers, (c) => { return c.id == customer.id });
        }
    }
    }
</script>


<
template>


<template>
    
   

    <div>


        <br/>

        <p v-if="customers.length <= 0">There are currently no customerDtoDtos!</p>

        
        <p>
            <span><a href="/customers/New" class="btn btn-success btn-xs">Add New</a></span>
        </p>
        <table class="table table-bordered table-hover">
            <thead>
                <tr>
                    <th>Customer</th>
                    <th>Membership Type</th>

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
    </div>
</template>