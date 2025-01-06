import Vue from 'vue'//导入vue.js库
import App from './App.vue'//导入App.vue组件
import router from './router'//导入router.js路由
import ElementUI from 'element-ui'//导入element-ui库
import 'element-ui/lib/theme-chalk/index.css'//导入element-ui样式

Vue.use(ElementUI)//使用element-ui库
Vue.config.productionTip = false//阻止启动生产消息

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')