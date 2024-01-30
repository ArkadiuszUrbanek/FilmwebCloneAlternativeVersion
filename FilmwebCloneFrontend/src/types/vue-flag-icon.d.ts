declare module 'vue-flag-icon' {
    import Vue, { PluginFunction } from 'vue'

    const install: PluginFunction<{}>

    class FlagIcon extends Vue {
        iso: string
        title: string
        squared: boolean
    }
    
    export { install, FlagIcon }
}