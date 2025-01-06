<template>
  <div class="attractions-container">
    <h2>命运2年度扩展系列</h2>
    <el-input v-model="searchQuery" placeholder="搜索扩展" class="search-input" @input="filterAttractions"></el-input>
    <el-row :gutter="20" class="attractions-row">
      <el-col :span="8" v-for="attraction in filteredAttractions" :key="attraction.id">
        <el-card class="attraction-card" shadow="hover">
          <img :src="attraction.image" :alt="attraction.title" class="attraction-image" @click="navigateToGameDetail(attraction.id)" />
          <div class="attraction-info">
            <h3>{{ attraction.title }}</h3>
            <p>{{ attraction.description }}</p>
          </div>
        </el-card>
      </el-col>
    </el-row>
  </div>
</template>

<script>
export default {
  data() {
    return {
      searchQuery: '',
      attractions: [
        {
          id: 'TheFinalShape',
          title: '年7扩展终焉之形',
          description: '探索《命运2》的最后篇章，终焉之形带来一系列充满挑战的任务和新的敌人，绝对是玩家不能错过的一场战斗！',
          image: require('@/image/TheFinalShape.jpg')
        },
        {
          id: 'Lightfall',
          title: '年6扩展光陨之秋',
          description: '《命运2》光陨之秋扩展包带来了新的战斗模式和神秘的敌人，挑战玩家的极限并引发新的剧情。',
          image: require('@/image/Lightfall.jpg')
        },
        {
          id: 'WitchQueen',
          title: '年5扩展邪姬魅影',
          description: '探索《命运2》的邪姬魅影故事，新敌人的出现将带来更加复杂的任务和更多的合作挑战。',
          image: require('@/image/WitchQueen.jpg')
        },
        {
          id: 'BeyondLight',
          title: '年4扩展凌光之刻',
          description: '在《命运2》的“凌光之刻”扩展中，玩家将前往欧洲的冰封世界，解锁强大的“凌光”力量，面对神秘的敌人“永夜”。这是一次与黑暗力量斗争的历险，挑战新的敌人，探索遗失的知识，揭开月球上隐藏的秘密。',
          image: require('@/image/BeyondLight.jpg')
        },
        {
          id: 'Shadowkeep',
          title: '年3扩展暗影要塞',
          description: '《命运2：暗影要塞》扩展包带来了月球的重生。在新的冒险中，玩家将前往月球，揭开一段早已被遗忘的历史。面对邪恶的“梦魇”敌人，玩家将再次与最强的敌人对抗，并解开月球上隐藏的秘密。',
          image: require('@/image/Shadowkeep.jpg')
        },
        {
          id: 'Forsaken',
          title: '年2扩展遗落之族',
          description: '在《命运2：遗落之族》扩展包中，玩家将展开复仇之旅，为被杀害的先锋凯德复仇。追寻凶手的踪迹，揭开神秘的“遗落之族”背后隐藏的真相。全新的故事和任务线，将带你进入一个充满黑暗与光明交织的世界。',
          image: require('@/image/Forsaken.jpg')
        }
      ],
      filteredAttractions: []
    }
  },
  created() {
    this.filteredAttractions = this.attractions;
  },
  methods: {
    navigateToGameDetail(gameId) {
      this.$router.push({ name: 'GameDetail', params: { gameId } });
    },
    filterAttractions() {
      const query = this.searchQuery.toLowerCase();
      this.filteredAttractions = this.attractions.filter(attraction => 
        attraction.title.toLowerCase().includes(query) || 
        attraction.description.toLowerCase().includes(query)
      );
    }
  }
}
</script>

<style scoped>
.attractions-container {
  padding: 20px;
}

.search-input {
  margin-bottom: 20px;
}

.attraction-card {
  margin-bottom: 20px;
  transition: transform 0.3s ease-in-out;
}

.attraction-card:hover {
  transform: translateY(-10px); /* 鼠标悬停时卡片上移 */
  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.3); /* 增加阴影效果 */
}

.attraction-image {
  width: 100%;
  height: 300px;
  object-fit: cover;
  transition: transform 0.3s ease-in-out;
}

.attraction-image:hover {
  transform: scale(1.05); /* 鼠标悬停时图片放大 */
}

.attraction-info {
  margin-top: 10px;
}

h2 {
  text-align: center;
  margin-bottom: 20px;
}

.el-button {
  margin-top: 10px;
}

.light .attraction-card {
  background-color: #ffffff;
  color: #000000;
}

.dark .attraction-card {
  background-color: #2c3e50;
  color: #ffffff;
}
</style>
