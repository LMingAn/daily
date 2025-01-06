<!-- src/components/TopicsCard.vue -->
<template>
  <div class="topics-card" @click="goToDetailPage">
    <div class="topics-card-content">
      <h3 class="topics-title">{{ topic.title }}</h3>
      <p class="topics-description">{{ topic.description }}</p>
    </div>
  </div>
</template>

<script>
export default {
  name: 'TopicsCard',
  props: {
    topic: {
      type: Object,
      required: true,
    },
  },
  methods: {
    goToDetailPage() {
      this.$router.push({ name: 'topicDetail', params: { topicId: this.topic.id } });
    },
  },
};
</script>

<style scoped>
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
