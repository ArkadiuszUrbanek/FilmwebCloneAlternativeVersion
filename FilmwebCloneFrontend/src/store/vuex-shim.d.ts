import { Store } from 'vuex'
import type { LoginInfoType } from '../types/LoginInfoType'

declare module '@vue/runtime-core' {
  interface ComponentCustomProperties {
    $store: Store<LoginInfoType>
  }
}