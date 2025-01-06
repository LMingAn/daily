<template>
  <div>
    <AppNavbar />
    <div class="topics-list">
      <TopicsCard v-for="topic in topics" :key="topic.id" :topic="topic" />
    </div>
    <AppFooter />
  </div>
</template>

<script>
import AppNavbar from '../components/AppNavbar.vue';
import TopicsCard from '../components/TopicsCard.vue';
import AppFooter from '../components/AppFooter.vue';

export default {
  name: 'AppTopics',
  components: {
    AppNavbar,
    TopicsCard,
    AppFooter,
  },
  data() {
    return {
      topics: [
        { id: 1, title: 'Vue.js 入门', description: '学习 Vue.js 基础知识' },
        { id: 2, title: 'Vue Router 使用指南', description: '理解 Vue Router 的使用方法' },
        { id: 3, title: 'Vuex 状态管理', description: '学习 Vuex 如何进行全局状态管理' },
      ],
    };
  },
};
</script>

<style scoped>
.topics-list {
  display: flex;
  flex-direction: column;  /* 改为竖直排列 */
  align-items: center;  /* 垂直居中 */
  gap: 20px;
  justify-content: flex-start;
}

.topics-card {
  width: 300px;
  padding: 20px;
  background-color: #f9f9f9;
  border-radius: 8px;
  box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
  cursor: pointer;
  transition: transform 0.3s ease;
}

.topics-card:hover {
  transform: scale(1.05);
}

.topics-card-content {
  text-align: center;
}

.topics-title {
  font-size: 1.2em;
  font-weight: bold;
}

.topics-description {
  color: #555;
}
</style>
