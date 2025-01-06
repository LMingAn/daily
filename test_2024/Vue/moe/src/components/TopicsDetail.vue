<!-- src/components/TopicsDetail.vue -->
<template>
  <div class="topic-detail">
    <h2 class="topic-title">{{ topicDetail.title }}</h2>
    <p class="topic-description">{{ topicDetail.description }}</p>
    <div class="topic-content">
      <p>{{ topicDetail.content }}</p>
    </div>
    <router-link to="/" class="back-link">返回首页</router-link>
  </div>
</template>

<script>
export default {
  name: 'TopicsDetail',
  data() {
    return {
      topicDetail: {},
    };
  },
  created() {
    const topicId = this.$route.params.topicId;
    // 模拟通过 ID 获取数据
    this.fetchTopicDetail(topicId);
  },
  methods: {
    fetchTopicDetail(topicId) {
      // 假设从 API 或本地数据中获取专题的详细信息
      const topics = [
        {
          id: 1,
          title: 'Vue.js 入门',
          description: '学习 Vue.js 基础知识',
          content: 'Vue.js 是一个渐进式框架，用于构建用户界面...',
        },
        {
          id: 2,
          title: 'Vue Router 使用指南',
          description: '理解 Vue Router 的使用方法',
          content: 'Vue Router 是 Vue.js 官方的路由管理库...',
        },
        {
          id: 3,
          title: 'Vuex 状态管理',
          description: '学习 Vuex 如何进行全局状态管理',
          content: 'Vuex 是 Vue.js 官方的状态管理库...',
        },
      ];

      this.topicDetail = topics.find((topic) => topic.id === parseInt(topicId));
    },
  },
};
</script>

<style scoped>
.topic-detail {
  padding: 20px;
  max-width: 800px;
  margin: 0 auto;
}

.topic-title {
  font-size: 2em;
  font-weight: bold;
}

.topic-description {
  font-size: 1.2em;
  color: #555;
}

.topic-content {
  margin-top: 20px;
}

.back-link {
  display: inline-block;
  margin-top: 20px;
  font-size: 1.1em;
  text-decoration: none;
  color: #007bff;
}

.back-link:hover {
  text-decoration: underline;
}
</style>
