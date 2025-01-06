<!-- src/App.vue -->
<template>
  <div id="app">
    <router-view></router-view>  <!-- 渲染当前路由的组件 -->
  </div>
</template>

<script>
export default {
  name: 'App',  // 根组件的名称
};
</script>

<style>
/* 全局样式 */
#app {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
}

.content {
  padding-top: 60px; /* 给页面内容加上顶部间距，补偿固定的导航栏高度 */
}
</style>
