<template>
    <div class="bg-white h-fit w-1/3 rounded-2xl border px-5 py-5">
        <form v-on:submit.prevent="onSubmit">
            <p class="font-bold">Title</p>
            <input 
                type="text"
                v-model="v$.name.$model"
                v-on:blur="v$.name.$touch()"
                v-bind:class="{ 'border-red-500': v$.name.$error }" 
                class="w-full bg-gray-100 rounded border border-gray-400 leading-normal py-2 px-3 font-normal focus:outline-none focus:bg-white"
            >
            <template v-for="(error, index) in v$.name.$errors" :key="index">
                    <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
            </template>
            <p class="font-bold mt-2">Initial message</p>
            <textarea 
                v-model="v$.initialMessageText.$model"
                v-on:blur="v$.initialMessageText.$touch()"
                v-bind:class="{ 'border-red-500': v$.initialMessageText.$error }"
                class="w-full bg-gray-100 rounded border border-gray-400 resize-none leading-normal h-auto py-2 px-3 font-normal focus:outline-none focus:bg-white" 
                rows="6">
            </textarea>
            <template v-for="(error, index) in v$.initialMessageText.$errors" :key="index">
                    <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
            </template>
            <button
                type="submit"
                v-bind:disabled="v$.$invalid"
                v-bind:class="{ 'cursor-not-allowed': v$.$invalid }" 
                class="px-3 py-2 bg-yellow-400 hover:bg-yellow-500 rounded-full drop-shadow-md float-right font-bold">
                Confirm
            </button>
        </form>
        
    </div>
</template>

<script lang="ts">
    import { Modal } from 'jenesius-vue-modal'
    import useVuelidate from '@vuelidate/core'
    import { required } from '@vuelidate/validators'

    export default {
        setup: () => ({ v$: useVuelidate() }),
        data() {
            return {
                name: undefined as string | undefined,
                initialMessageText: undefined as string | undefined
            }
        },
        validations() {
            return {
                name: { required },
                initialMessageText: { required }
            }
        },
        methods: {
            onSubmit() {
                this.v$.$validate()
                .then(() => {
                    this.$emit(Modal.EVENT_PROMPT, {
                        name: this.name,
                        initialMessageText: this.initialMessageText
                    })
                })
                .catch((error) => {
                    alert('Form data is invalid.')
                })
            }
        }
    }
</script>