<template>
  <div class="home-container">
    <!-- 游戏介绍 -->
    <el-card class="game-intro game-card" :body-style="{ padding: '20px' }">
      <h2>游戏介绍</h2>
      <p>欢迎来到《命运2》世界！探索广袤的宇宙，参与激烈的PvP战斗，挑战强大的敌人，收集装备，和你的队友一起拯救世界！</p>
      <el-button type="primary" @click="goToExternalSite('https://www.bungie.net/7/zh-chs/Destiny/NewLight')">了解更多</el-button>
    </el-card>

    <!-- 游戏新闻 -->
    <el-card class="game-news game-card" :body-style="{ padding: '20px' }">
      <h2>游戏新闻</h2>
      <el-button type="primary" @click="showNewsDialog = true">新增新闻</el-button>
      <el-row :gutter="20">
        <el-col :span="8" v-for="(news, index) in newsList" :key="index">
          <el-card class="news-card game-card" shadow="hover">
            <h3>{{ news.title }}</h3>
            <p>{{ news.summary }}</p>
            <el-button type="text" @click="editNews(news)">编辑</el-button>
            <el-button type="text" @click="deleteNews(index)">删除</el-button>
          </el-card>
        </el-col>
      </el-row>
    </el-card>

    <!-- 更新日志 -->
    <el-card class="game-update-log game-card" :body-style="{ padding: '20px' }">
      <h2>更新日志</h2>
      <el-button type="primary" @click="showUpdateDialog = true">新增更新日志</el-button>
      <el-tabs v-model="activeTab">
        <el-tab-pane label="最新更新" name="latest">
          <div v-for="(update, index) in updateLogs.latest" :key="index">
            <h4>{{ update.version }} - {{ update.date }}</h4>
            <p>{{ update.changes }}</p>
            <el-button type="text" @click="editUpdate('latest', index)">编辑</el-button>
            <el-button type="text" @click="deleteUpdate('latest', index)">删除</el-button>
          </div>
        </el-tab-pane>
        <el-tab-pane label="历史更新" name="history">
          <div v-for="(update, index) in updateLogs.history" :key="index">
            <h4>{{ update.version }} - {{ update.date }}</h4>
            <p>{{ update.changes }}</p>
            <el-button type="text" @click="editUpdate('history', index)">编辑</el-button>
            <el-button type="text" @click="deleteUpdate('history', index)">删除</el-button>
          </div>
        </el-tab-pane>
      </el-tabs>
    </el-card>

    <!-- 新闻编辑对话框 -->
    <el-dialog title="编辑新闻" :visible.sync="showNewsDialog">
      <el-form :model="newsForm" :rules="newsRules" ref="newsForm" label-width="80px">
        <el-form-item label="标题" prop="title">
          <el-input v-model="newsForm.title"></el-input>
        </el-form-item>
        <el-form-item label="摘要" prop="summary">
          <el-input v-model="newsForm.summary"></el-input>
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="showNewsDialog = false">取消</el-button>
        <el-button type="primary" @click="saveNews">保存</el-button>
      </div>
    </el-dialog>

    <!-- 更新日志编辑对话框 -->
    <el-dialog title="编辑更新日志" :visible.sync="showUpdateDialog">
      <el-form :model="updateForm" :rules="updateRules" ref="updateForm" label-width="80px">
        <el-form-item label="版本" prop="version">
          <el-input v-model="updateForm.version"></el-input>
        </el-form-item>
        <el-form-item label="日期" prop="date">
          <el-date-picker v-model="updateForm.date" type="date" placeholder="选择日期"></el-date-picker>
        </el-form-item>
        <el-form-item label="更新内容" prop="changes">
          <el-input type="textarea" v-model="updateForm.changes"></el-input>
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="showUpdateDialog = false">取消</el-button>
        <el-button type="primary" @click="saveUpdate">保存</el-button>
      </div>
    </el-dialog>
  </div>
</template>

<script>
export default {
  name: 'Home',
  data() {
    return {
      activeTab: 'latest',
      newsList: [
        { id: 1, title: '《命运2》新赛季开启', summary: '全新的赛季内容已经上线，挑战新的敌人，赢取丰厚奖励！' },
        { id: 2, title: '游戏服务器维护', summary: '《命运2》将于今晚进行服务器维护，预计持续2小时。' },
        { id: 3, title: '全新武器加入', summary: '新的武器种类已加入游戏，让你拥有更多战斗选择！' }
      ],
      updateLogs: {
        latest: [
          { version: 'v1.3.2', date: '2024-12-20', changes: '修复了一些游戏BUG，优化了加载速度。' },
          { version: 'v1.3.1', date: '2024-12-15', changes: '新增了新功能——多人合作任务！' }
        ],
        history: [
          { version: 'v1.2.5', date: '2024-11-30', changes: '改进了游戏的平衡性，修复了几个严重BUG。' },
          { version: 'v1.2.0', date: '2024-10-25', changes: '发布了新的扩展包，加入了更多的敌人和任务。' }
        ]
      },
      showNewsDialog: false,
      showUpdateDialog: false,
      newsForm: {
        title: '',
        summary: ''
      },
      updateForm: {
        version: '',
        date: '',
        changes: ''
      },
      newsRules: {
        title: [
          { required: true, message: '请输入标题', trigger: 'blur' }
        ],
        summary: [
          { required: true, message: '请输入摘要', trigger: 'blur' }
        ]
      },
      updateRules: {
        version: [
          { required: true, message: '请输入版本号', trigger: 'blur' }
        ],
        date: [
          { required: true, message: '请选择日期', trigger: 'change' }
        ],
        changes: [
          { required: true, message: '请输入更新内容', trigger: 'blur' }
        ]
      },
      editingNewsIndex: null,
      editingUpdateIndex: null,
      editingUpdateType: null
    }
  },
  methods: {
    goToExternalSite(url) {
      // 跳转到游戏详细介绍页面
      window.open(url, '_blank');
    },
    editNews(news) {
      this.newsForm = { ...news };
      this.editingNewsIndex = this.newsList.indexOf(news);
      this.showNewsDialog = true;
    },
    deleteNews(index) {
      this.newsList.splice(index, 1);
    },
    saveNews() {
      this.$refs.newsForm.validate(valid => {
        if (valid) {
          if (this.editingNewsIndex !== null) {
            this.newsList.splice(this.editingNewsIndex, 1, { ...this.newsForm });
          } else {
            this.newsList.push({ ...this.newsForm });
          }
          this.showNewsDialog = false;
          this.newsForm = { title: '', summary: '' };
          this.editingNewsIndex = null;
        }
      });
    },
    editUpdate(type, index) {
      this.updateForm = { ...this.updateLogs[type][index] };
      this.editingUpdateType = type;
      this.editingUpdateIndex = index;
      this.showUpdateDialog = true;
    },
    deleteUpdate(type, index) {
      this.updateLogs[type].splice(index, 1);
    },
    saveUpdate() {
      this.$refs.updateForm.validate(valid => {
        if (valid) {
          const formattedDate = new Date(this.updateForm.date).toISOString().split('T')[0]; // 格式化日期为 YYYY-MM-DD
          const updateData = { ...this.updateForm, date: formattedDate };
          if (this.editingUpdateIndex !== null) {
            this.updateLogs[this.editingUpdateType].splice(this.editingUpdateIndex, 1, updateData);
          } else {
            this.updateLogs[this.activeTab].push(updateData); // 修复保存时未指定类型的问题
          }
          this.showUpdateDialog = false;
          this.updateForm = { version: '', date: '', changes: '' };
          this.editingUpdateIndex = null;
          this.editingUpdateType = null;
        }
      });
    }
  }
}
</script>

<style scoped>
.home-container {
  padding: 20px;
}

.game-intro {
  margin-bottom: 20px;
}

.game-news .news-card {
  margin-bottom: 20px;
}

.game-update-log {
  margin-top: 40px;
}

.el-tabs {
  margin-top: 20px;
}

.game-card {
  border-radius: 8px;
  overflow: hidden;
  transition: transform 0.3s ease-in-out;
}

.game-card:hover {
  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.3); /* 增加阴影效果 */
}

.light .game-card {
  background-color: #ffffff;
  color: #000000;
}

.dark .game-card {
  background-color: #2c3e50;
  color: #ffffff;
}

.dark .el-tab-pane {
  color: #ffffff; /* 深色模式下更新日志字体颜色为白色 */
}

.dark .el-tab-pane h4,
.dark .el-tab-pane p {
  color: #ffffff; /* 深色模式下更新日志标题和内容字体颜色为白色 */
}
</style>
