<template>
    <div>

        

        
    </div>
</template>
<style></style>



<script>
    import FormHelper from '../../mixins/FormHelper';

    export default {
        mixins:[FormHelper],
        data(){
            return {

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
                alert('all set')
            });
        },

        methods: {

        }

    }
</script>

