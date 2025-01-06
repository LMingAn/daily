<template>
  <div id="app" :class="theme">
    <el-container v-if="showHeader">
      <el-header>
        <el-menu :default-active="activeIndex" class="el-menu-demo" mode="horizontal" router>
          <el-menu-item index="/home">命运2</el-menu-item>
          <el-submenu index="expand-collection">
            <template #title>扩展合集</template>
            <el-menu-item index="/attractions">命运2年度扩展合集</el-menu-item>
            <el-menu-item @click="goToExternalSite('https://www.bungie.net/7/zh-chs/Destiny/TheFinalShape')">年7扩展终焉之形</el-menu-item>
            <el-menu-item @click="goToExternalSite('https://www.bungie.net/7/zh-chs/Destiny/Lightfall')">年6扩展光陨之秋</el-menu-item>
            <el-menu-item @click="goToExternalSite('https://www.bungie.net/7/zh-chs/Destiny/WitchQueen')">年5扩展邪姬魅影</el-menu-item>
            <el-menu-item @click="goToExternalSite('https://www.bungie.net/7/zh-chs/Destiny/BeyondLight')">年4扩展凌光之刻</el-menu-item>
            <el-menu-item @click="goToExternalSite('https://www.bungie.net/7/zh-chs/Destiny/Shadowkeep')">年3扩展暗影要塞</el-menu-item>
            <el-menu-item @click="goToExternalSite('https://www.bungie.net/7/zh-chs/Destiny/Forsaken')">年2扩展遗落之族</el-menu-item>          </el-submenu>
            <el-menu-item index="/profile">个人中心</el-menu-item>
            <el-menu-item index="/login" v-if="!isLoggedIn">登录</el-menu-item>
            <el-menu-item @click="handleLogout" v-else>退出登录</el-menu-item>
            <el-menu-item style="float: right">
              <div class="header">
                <div class="clock">{{ currentTime }}</div>
                <el-button @click="toggleTheme" class="theme-toggle-btn">
                  切换到{{ theme === 'light' ? '黑夜' : '白天' }}模式
                </el-button>
              </div>
            </el-menu-item>
        </el-menu>
      </el-header>
      <el-main>
        <router-view></router-view>
      </el-main>
    </el-container>
    <router-view v-else></router-view>
  </div>
</template>

<script>
export default {
  name: 'App',
  data() {
    return {
      activeIndex: '/home',
      isLoggedIn: false,
      currentTime: '',
      theme: localStorage.getItem('theme') || 'light'
    }
  },
  computed: {
    showHeader() {
      return !['Login', 'Register'].includes(this.$route.name)
    }
  },
  created() {
    this.isLoggedIn = !!localStorage.getItem('token')
    this.updateTime();  // 初始化时钟
    setInterval(this.updateTime, 1000);  // 每秒更新一次时间
  },
  methods: {
    handleLogout() {
      localStorage.removeItem('token');
      this.isLoggedIn = false;
      this.$router.push('/login');
    },
    goToExternalSite(url) {
      window.open(url, '_blank'); // 跳转到外部网页
    },
    updateTime() {
      const date = new Date();
      const hours = String(date.getHours()).padStart(2, '0');
      const minutes = String(date.getMinutes()).padStart(2, '0');
      const seconds = String(date.getSeconds()).padStart(2, '0');
      this.currentTime = `${hours}:${minutes}:${seconds}`;  // 格式化为 HH:MM:SS
    },
    toggleTheme() {
      this.theme = this.theme === 'light' ? 'dark' : 'light';
      localStorage.setItem('theme', this.theme);
    }
  }
}
</script>

<style>
#app {
  font-family: Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.el-header {
  padding: 0;
  background-color: #2c3e50; /* 确保顶部栏颜色为深色 */
}

.el-menu-demo {
  background-color: #2c3e50 !important; /* 确保菜单栏颜色为深色 */
  color: #ffffff !important; /* 确保菜单文字颜色为白色 */
}

.el-menu-demo .el-menu-item,
.el-menu-demo .el-submenu__title {
  color: #ffffffa9 !important; /* 确保菜单项文字颜色为白色 */
  font-weight: bold; /* 突出文字 */
}

.el-menu-demo .el-menu-item:hover,
.el-menu-demo .el-submenu__title:hover {
  color: #ffffff !important; /* 鼠标悬停时文字颜色为黑色 */
  background-color: transparent !important; /* 取消鼠标悬停时背景颜色改变 */
}

.el-menu-demo .el-menu-item.is-active,
.el-menu-demo .el-submenu__title.is-active {
  background-color: transparent !important; /* 取消选中项背景颜色改变 */
}

.header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 10px;
}

.clock {
  font-size: 18px;
  padding-right: 20px;
  font-weight: bold;
}

.theme-toggle-btn {
  z-index: 1000;
  background-color: transparent; /* 透明背景 */
  border: none; /* 无边框 */
}

.theme-icon {
  width: 24px; /* 图标宽度 */
  height: 24px; /* 图标高度 */
}

.light .theme-toggle-btn {
  background-color: #ffffff; /* 白天模式按钮颜色 */
  color: #000000; /* 白天模式按钮文字颜色 */
}

.dark .theme-toggle-btn {
  background-color: #2c3e50; /* 黑夜模式按钮颜色 */
  color: #ffffff; /* 黑夜模式按钮文字颜色 */
}

.light {
  background-color: #ffffff;
  color: #000000;
}

.dark {
  background-color: #1a1a1a; /* 更深的黑夜模式颜色 */
  color: #ffffff;
}
</style>