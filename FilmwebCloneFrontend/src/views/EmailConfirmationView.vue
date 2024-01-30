<template>
    <div class="flex items-center justify-center h-screen">
        <div class="flex flex-col items-center space-y-2">
            <template v-if="success === true">
                <svg class="success-svg-icon w-28 h-28" viewBox="0 0 20 20">
					<path fill="rgb(22 163 74)" d="M9.917,0.875c-5.086,0-9.208,4.123-9.208,9.208c0,5.086,4.123,9.208,9.208,9.208s9.208-4.122,9.208-9.208
						C19.125,4.998,15.003,0.875,9.917,0.875z M9.917,18.141c-4.451,0-8.058-3.607-8.058-8.058s3.607-8.057,8.058-8.057
						c4.449,0,8.057,3.607,8.057,8.057S14.366,18.141,9.917,18.141z M13.851,6.794l-5.373,5.372L5.984,9.672
						c-0.219-0.219-0.575-0.219-0.795,0c-0.219,0.22-0.219,0.575,0,0.794l2.823,2.823c0.02,0.028,0.031,0.059,0.055,0.083
						c0.113,0.113,0.263,0.166,0.411,0.162c0.148,0.004,0.298-0.049,0.411-0.162c0.024-0.024,0.036-0.055,0.055-0.083l5.701-5.7
						c0.219-0.219,0.219-0.575,0-0.794C14.425,6.575,14.069,6.575,13.851,6.794z">
                    </path>
				</svg>
                <h1 class="text-4xl font-bold">Success!</h1>
                <p>Your email address has been succesfully confirmed.</p>
                <div class="flex items-center space-x-2 py-1">
                    <router-link to="/" class="flex space-x-2 items-center px-3 py-2 bg-black hover:bg-gray-800 rounded-full drop-shadow-md">
                        <svg class="text-white" width="24" height="24" x="0px" y="0px" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24">
                            <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="m4 12 8-8 8 8M6 10.5V19c0 .6.4 1 1 1h3v-3c0-.6.4-1 1-1h2c.6 0 1 .4 1 1v3h3c.6 0 1-.4 1-1v-8.5"/>
                        </svg>
                        <span class="text-white text-sm font-medium">Home</span>
                    </router-link>
                    <router-link to="/login" class="flex space-x-2 items-center px-3 py-2 bg-black hover:bg-gray-800 rounded-full drop-shadow-md">
                        <svg class="text-white" width="24" height="24" x="0px" y="0px" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24">
                            <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M21 12c.1 3-.2 6-1 9M7.1 4.4a9 9 0 0 1 13 3.7M3 15v-3a9 9 0 0 1 1.7-5.3m12.9 3c.3.8.4 1.5.4 2.3 0 2 0 4.2-.5 6.2M6 12a6 6 0 0 1 9.4-5M4 21a6 6 0 0 1 1-3.3 5 5 0 0 0 .8-2m8.7 2.5a14 14 0 0 1-1 2.7m-6-1.6C9 17.1 9 14.8 9 12a3 3 0 1 1 6 0v2.3M12 12c0 3 0 6-2 9"/>
                        </svg>
                        <span class="text-white text-sm font-medium">Login</span>
                    </router-link>
                </div>
            </template>
            <template v-else-if="success === false">
                <svg class="fail-svg-icon w-28 h-28" viewBox="0 0 20 20">
				    <path fill="rgb(239 68 68)" d="M13.864,6.136c-0.22-0.219-0.576-0.219-0.795,0L10,9.206l-3.07-3.07c-0.219-0.219-0.575-0.219-0.795,0
					    c-0.219,0.22-0.219,0.576,0,0.795L9.205,10l-3.07,3.07c-0.219,0.219-0.219,0.574,0,0.794c0.22,0.22,0.576,0.22,0.795,0L10,10.795
					    l3.069,3.069c0.219,0.22,0.575,0.22,0.795,0c0.219-0.22,0.219-0.575,0-0.794L10.794,10l3.07-3.07
					    C14.083,6.711,14.083,6.355,13.864,6.136z M10,0.792c-5.086,0-9.208,4.123-9.208,9.208c0,5.085,4.123,9.208,9.208,9.208
					    s9.208-4.122,9.208-9.208C19.208,4.915,15.086,0.792,10,0.792z M10,18.058c-4.451,0-8.057-3.607-8.057-8.057
					    c0-4.451,3.606-8.057,8.057-8.057c4.449,0,8.058,3.606,8.058,8.057C18.058,14.45,14.449,18.058,10,18.058z">
                    </path>
			    </svg>
                <h1 class="text-4xl font-bold">Error!</h1>
                <p>System failed to confirm your email address.</p>
            </template>
            <template v-else>
                <p>Confirming email...</p>
            </template>
        </div>
    </div>
</template>

<script lang="ts">
    import axios from 'axios'

    export default {
        data() {
            return {
                token: undefined as string | undefined,
                userId: undefined as string | undefined,
                success: undefined as boolean | undefined
            }
        },
        mounted() {
            this.token = this.$route.query.token as string | undefined
            this.userId = this.$route.query.userId as string | undefined

            if (!this.token || !this.userId) return

            axios.patch('Auth/email-confirm', 
            {
                token: this.token,
                userId: this.userId
            }).then((response) => {
                this.success = true
                this.$toast.open({
                    message: 'Email address has been confirmed.',
                    type: 'success'
                })

            }).catch((error) => {
                this.success = false
                this.$toast.open({
                    message: 'Failed to confirm email address.',
                    type: 'error'
                })
            })
        }
    }
</script>
