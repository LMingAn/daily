<template>
  <div class="game-detail-container">
    <el-card class="game-card" :body-style="{ padding: '20px' }">
      <h2 class="section-title">截图&壁纸</h2>
      <el-carousel :interval="3000" arrow="always" height="700px">
        <el-carousel-item v-for="(image, index) in game.images" :key="index">
          <img :src="image" class="carousel-image" />
        </el-carousel-item>
      </el-carousel>
    </el-card>
    <el-card class="game-card" :body-style="{ padding: '20px', marginTop: '20px' }">
      <h2 class="section-title">宣传片</h2>
      <div class="video-container">
        <video controls :src="game.video" class="game-video"></video>
      </div>
    </el-card>
  </div>
</template>

<script>
export default {
  name: 'GameDetail',
  data() {
    return {
      game: {
        images: [],
        video: ''
      }
    }
  },
  created() {
    this.loadGameDetails();
  },
  methods: {
    loadGameDetails() {
      const gameId = this.$route.params.gameId;
      // 根据gameId加载相应的游戏详情
      switch (gameId) {
        case 'TheFinalShape':
          this.game.images = [
            require('@/image/TheFinalShape1.jpg'),
            require('@/image/TheFinalShape2.jpg'),
            require('@/image/TheFinalShape3.jpg'),
            require('@/image/TheFinalShape4.jpg'),
            require('@/image/TheFinalShape5.jpg'),
            require('@/image/TheFinalShape6.jpg'),
            require('@/image/TheFinalShape7.jpg')
          ];
          this.game.video = require('@/video/TheFinalShape.mp4');
          break;
        case 'Lightfall':
          this.game.images = [
            require('@/image/Lightfall1.jpg'),
            require('@/image/Lightfall2.jpg'),
            require('@/image/Lightfall3.jpg'),
            require('@/image/Lightfall4.jpg'),
            require('@/image/Lightfall5.jpg'),
            require('@/image/Lightfall6.jpg')
          ];
          this.game.video = require('@/video/Lightfall.mp4');
          break;
        case 'WitchQueen':
          this.game.images = [
            require('@/image/WitchQueen1.jpg'),
            require('@/image/WitchQueen2.jpg'),
            require('@/image/WitchQueen3.jpg'),
            require('@/image/WitchQueen4.jpg'),
            require('@/image/WitchQueen5.jpg'),
            require('@/image/WitchQueen6.jpg')
          ];
          this.game.video = require('@/video/WitchQueen.mp4');
          break;
        case 'BeyondLight':
          this.game.images = [
            require('@/image/BeyondLight1.jpg'),
            require('@/image/BeyondLight2.jpg'),
            require('@/image/BeyondLight3.jpg')
          ];
          this.game.video = require('@/video/BeyondLight.mp4');
          break;
        case 'Shadowkeep':
          this.game.images = [
            require('@/image/Shadowkeep1.jpg'),
            require('@/image/Shadowkeep2.jpg'),
            require('@/image/Shadowkeep3.jpg')
          ];
          this.game.video = require('@/video/Shadowkeep.mp4');
          break;
        case 'Forsaken':
          this.game.images = [
            require('@/image/Forsaken1.jpg'),
            require('@/image/Forsaken2.jpg'),
            require('@/image/Forsaken3.jpg')
          ];
          this.game.video = require('@/video/Forsaken.mp4');
          break;
        default:
          this.game.images = [];
          this.game.video = '';
      }
    }
  }
}
</script>

<style scoped>
.game-detail-container {
  padding: 20px;
}

.section-title {
  margin-top: 20px;
  margin-bottom: 10px;
  font-size: 24px;
  text-align: center;
}

.carousel-image {
  width: 100%;
  height: 700px;
  object-fit: cover;
}

.video-container {
  margin-top: 20px;
  text-align: center;
}

.game-video {
  width: 100%;
  max-width: 80%;
  height: auto;
}

.game-card {
  transition: none; /* 移除鼠标悬浮卡片上浮效果 */
}

.light .game-card {
  background-color: #ffffff;
  color: #000000;
}

.dark .game-card {
  background-color: #2c3e50;
  color: #ffffff;
}
</style>
