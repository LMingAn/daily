<template>
  <div class="profile-container">
    <el-row :gutter="20">
      <!-- 左侧个人信息卡片 -->
      <el-col :span="8">
        <el-card class="profile-card">
          <div class="avatar-container">
            <el-avatar :size="100" :src="userInfo.avatar"></el-avatar>
            <h2>{{ userInfo.name }}</h2>
          </div>
          <div class="info-list">
            <div class="info-item">
              <span>用户名：</span>
              <span>{{ userInfo.username }}</span>
            </div>
            <div class="info-item">
              <span>性别：</span>
              <span>{{ userInfo.gender === 'male' ? '男' : '女' }}</span>
            </div>
            <div class="info-item">
              <span>注册时间：</span>
              <span>{{ userInfo.registerDate }}</span>
            </div>
          </div>
          <el-button type="primary" @click="showEditDialog = true">编辑个人信息</el-button>
        </el-card>
      </el-col>

      <!-- 右侧内容区域 -->
      <el-col :span="16">
        <el-tabs v-model="activeTab">
          <!-- 我的帖子 -->
          <el-tab-pane label="我的帖子" name="posts">
            <div class="posts-header">
              <h3>我的帖子</h3>
              <el-button type="primary" size="small" @click="createPost">
                <i class="el-icon-plus"></i> 发布新帖子
              </el-button>
            </div>
            
            <!-- 帖子列表 -->
            <div class="posts-list" v-loading="postsLoading">
              <el-card v-for="post in posts" :key="post.id" class="post-card">
                <div class="post-header">
                  <h3>{{ post.title }}</h3>
                  <div class="post-meta">
                    <span class="post-date">
                      <i class="el-icon-time"></i>
                      {{ post.updateTime || post.createTime }}
                    </span>
                    <span v-if="post.updateTime" class="post-edited">(已编辑)</span>
                  </div>
                </div>
                <p class="post-content">{{ post.content }}</p>
                <div class="post-footer">
                  <div class="post-stats">
                    <span>
                      <i class="el-icon-view"></i> {{ post.views }}
                    </span>
                    <span>
                      <i class="el-icon-chat-dot-round"></i> {{ post.comments }}
                    </span>
                  </div>
                  <div class="post-actions">
                    <el-button type="text" @click="editPost(post)">
                      <i class="el-icon-edit"></i> 编辑
                    </el-button>
                    <el-button type="text" class="delete-btn" @click="deletePost(post.id)">
                      <i class="el-icon-delete"></i> 删除
                    </el-button>
                  </div>
                </div>
              </el-card>
              
              <!-- 空状态 -->
              <el-empty
                v-if="!postsLoading && posts.length === 0"
                description="暂无帖子，快来发布第一篇帖子吧！"
              >
                <el-button type="primary" @click="createPost">发布帖子</el-button>
              </el-empty>
            </div>
          </el-tab-pane>
        </el-tabs>
      </el-col>
    </el-row>

    <!-- 编辑个人信息对话框 -->
    <el-dialog title="编辑个人信息" :visible.sync="showEditDialog">
      <el-form :model="editForm" :rules="rules" ref="editForm" label-width="80px">
        <el-form-item label="用户名" prop="username">
          <el-input v-model="editForm.username"></el-input>
        </el-form-item>
        <el-form-item label="姓名" prop="name">
          <el-input v-model="editForm.name"></el-input>
        </el-form-item>
        <el-form-item label="性别" prop="gender">
          <el-radio-group v-model="editForm.gender">
            <el-radio label="male">男</el-radio>
            <el-radio label="female">女</el-radio>
          </el-radio-group>
        </el-form-item>
        <el-form-item label="密码" prop="password">
          <el-input v-model="editForm.password" type="password" placeholder="不修改请留空"></el-input>
        </el-form-item>
        <el-form-item label="确认密码" prop="confirmPassword">
          <el-input v-model="editForm.confirmPassword" type="password" placeholder="不修改请留空"></el-input>
        </el-form-item>
        <el-form-item label="头像" prop="avatar">
          <el-upload
            class="avatar-uploader"
            action=""
            :show-file-list="false"
            :on-change="handleAvatarChange"
          >
            <img v-if="editForm.avatar" :src="editForm.avatar" class="avatar">
            <i v-else class="el-icon-plus avatar-uploader-icon"></i>
          </el-upload>
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="showEditDialog = false">取消</el-button>
        <el-button type="primary" @click="handleSaveProfile">保存</el-button>
      </div>
    </el-dialog>

    <!-- 帖子编辑对话框 -->
    <el-dialog 
      :title="postForm.id ? '编辑帖子' : '发布帖子'" 
      :visible.sync="showPostDialog"
      width="50%"
    >
      <el-form 
        :model="postForm" 
        :rules="postRules" 
        ref="postForm" 
        label-width="80px"
      >
        <el-form-item label="标题" prop="title">
          <el-input v-model="postForm.title"></el-input>
        </el-form-item>
        <el-form-item label="内容" prop="content">
          <el-input 
            type="textarea" 
            v-model="postForm.content" 
            :rows="6"
          ></el-input>
        </el-form-item>
      </el-form>
      <div slot="footer">
        <el-button @click="showPostDialog = false">取消</el-button>
        <el-button type="primary" @click="handleSavePost">保存</el-button>
      </div>
    </el-dialog>
  </div>
</template>

<script>
export default {
  name: 'Profile',
  data() {
    // 密码验证规则
    const validatePass = (rule, value, callback) => {
      if (value && value !== this.editForm.password) {
        callback(new Error('两次输入密码不一致!'))
      } else {
        callback()
      }
    }

    return {
      activeTab: 'posts',
      showEditDialog: false,
      userInfo: {
        username: 'user123',
        name: '千纱',
        gender: 'female',
        avatar: require('@/image/千纱.png'),
        registerDate: '2024-01-01'
      },
      editForm: {
        username: '',
        name: '',
        gender: '',
        password: '',
        confirmPassword: '',
        avatar: ''
      },
      rules: {
        username: [
          { required: true, message: '请输入用户名', trigger: 'blur' },
          { min: 3, max: 20, message: '长度在 3 到 20 个字符', trigger: 'blur' }
        ],
        name: [
          { required: true, message: '请输入姓名', trigger: 'blur' }
        ],
        gender: [
          { required: true, message: '请选择性别', trigger: 'change' }
        ],
        confirmPassword: [
          { validator: validatePass, trigger: 'blur' }
        ]
      },
      postsLoading: false,
      posts: [],
      postForm: {
        id: null,
        title: '',
        content: '',
        createTime: '',
        updateTime: '',
        views: 0,
        comments: 0
      },
      postRules: {
        title: [
          { required: true, message: '请输入标题', trigger: 'blur' },
          { min: 2, max: 50, message: '长度在 2 到 50 个字符', trigger: 'blur' }
        ],
        content: [
          { required: true, message: '请输入内容', trigger: 'blur' },
          { min: 10, max: 500, message: '长度在 10 到 500 个字符', trigger: 'blur' }
        ]
      }
    }
  },
  created() {
    this.loadUserInfo()
    this.loadPosts()
  },
  methods: {
    loadUserInfo() {
      // 从本地存储获取用户信息
      const userInfo = JSON.parse(localStorage.getItem('userInfo') || '{}')
      if (userInfo.username) {
        this.userInfo = userInfo
        this.editForm = { ...userInfo, password: '', confirmPassword: '' }
      }
    },
    async loadPosts() {
      this.postsLoading = true
      try {
        const posts = JSON.parse(localStorage.getItem('userPosts') || '[]')
        this.posts = posts.sort((a, b) => {
          const timeA = new Date(b.updateTime || b.createTime)
          const timeB = new Date(a.updateTime || a.createTime)
          return timeA - timeB
        })
      } catch (error) {
        console.error('加载帖子失败:', error)
        this.$message.error('加载帖子失败')
      } finally {
        this.postsLoading = false
      }
    },
    handleSaveProfile() {
      this.$refs.editForm.validate(valid => {
        if (valid) {
          // 更新用户信息
          const updatedUserInfo = { ...this.userInfo, ...this.editForm }
          delete updatedUserInfo.password
          delete updatedUserInfo.confirmPassword
          localStorage.setItem('userInfo', JSON.stringify(updatedUserInfo))
          this.userInfo = updatedUserInfo
          this.showEditDialog = false
          this.$message.success('个人信息更新成功')
        }
      })
    },
    handleAvatarChange(file) {
      const reader = new FileReader();
      reader.onload = (e) => {
        this.editForm.avatar = e.target.result;
      };
      reader.readAsDataURL(file.raw);
    },
    editPost(post) {
      this.postForm = {
        id: post.id,
        title: post.title,
        content: post.content
      }
      this.showPostDialog = true
    },
    async handleSavePost() {
      try {
        await this.$refs.postForm.validate()
        
        // 获取现有帖子列表
        const posts = JSON.parse(localStorage.getItem('userPosts') || '[]')
        
        if (this.postForm.id) {
          // 更新现有帖子
          const index = posts.findIndex(p => p.id === this.postForm.id)
          if (index !== -1) {
            posts[index] = {
              ...posts[index],
              title: this.postForm.title,
              content: this.postForm.content,
              updateTime: new Date().toLocaleString()
            }
          }
        } else {
          // 创建新帖子
          posts.push({
            id: Date.now(),
            title: this.postForm.title,
            content: this.postForm.content,
            createTime: new Date().toLocaleString(),
            views: 0,
            comments: 0
          })
        }
        
        // 保存到本地存储
        localStorage.setItem('userPosts', JSON.stringify(posts))
        
        // 刷新帖子列表
        this.loadPosts()
        this.showPostDialog = false
        this.$message.success(this.postForm.id ? '更新成功' : '发布成功')
      } catch (error) {
        console.error('保存帖子失败:', error)
        this.$message.error('操作失败，请重试')
      }
    },
    async deletePost(id) {
      try {
        await this.$confirm('确定删除该帖子吗？删除后无法恢复', '提示', {
          type: 'warning'
        })
        
        // 从本地存储中删除
        const posts = JSON.parse(localStorage.getItem('userPosts') || '[]')
        const updatedPosts = posts.filter(post => post.id !== id)
        localStorage.setItem('userPosts', JSON.stringify(updatedPosts))
        
        // 更新页面显示
        this.posts = this.posts.filter(post => post.id !== id)
        this.$message.success('删除成功')
      } catch (error) {
        if (error !== 'cancel') {
          console.error('删除帖子失败:', error)
          this.$message.error('删除失败，请重试')
        }
      }
    },
    createPost() {
      this.postForm = {
        id: null,
        title: '',
        content: '',
        createTime: '',
        updateTime: '',
        views: 0,
        comments: 0
      }
      this.showPostDialog = true
    }
  }
}
</script>

<style scoped>
.profile-container {
  padding: 20px;
}

.profile-card {
  text-align: center;
}

.avatar-container {
  margin-bottom: 20px;
}

.info-list {
  text-align: left;
  margin: 20px 0;
}

.info-item {
  margin: 10px 0;
  display: flex;
  justify-content: space-between;
}

.attraction-card {
  margin-bottom: 20px;
  transition: all 0.3s;
}

.attraction-card:hover {
  transform: translateY(-5px);
  box-shadow: 0 2px 12px 0 rgba(0,0,0,0.1);
}

.image {
  width: 100%;
  height: 200px;
  object-fit: cover;
  display: block;
}

.card-content {
  padding: 14px;
}

.card-content h3 {
  margin: 0;
  font-size: 16px;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}

.card-content p {
  font-size: 14px;
  color: #666;
  margin: 10px 0;
  overflow: hidden;
  text-overflow: ellipsis;
  display: -webkit-box;
  -webkit-line-clamp: 2;
  line-clamp: 2;
  -webkit-box-orient: vertical;
  height: 40px;
}

.bottom {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-top: 13px;
}

.el-rate {
  display: inline-block;
}

.post-card {
  margin-bottom: 20px;
}

.post-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.post-date {
  color: #999;
  font-size: 14px;
}

.post-content {
  margin: 10px 0;
  color: #666;
}

.post-footer {
  display: flex;
  align-items: center;
  color: #999;
}

.post-footer span {
  margin-right: 20px;
}

.post-footer i {
  margin-right: 5px;
}

/* 适配不同屏幕尺寸 */
@media screen and (max-width: 1200px) {
  .el-col-8 {
    width: 50%;
  }
}

@media screen and (max-width: 768px) {
  .el-col-8 {
    width: 100%;
  }
}

.posts-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 20px;
}

.post-card {
  margin-bottom: 20px;
  transition: all 0.3s;
}

.post-card:hover {
  transform: translateY(-2px);
  box-shadow: 0 2px 12px 0 rgba(0,0,0,0.1);
}

.post-header {
  display: flex;
  justify-content: space-between;
  align-items: flex-start;
}

.post-meta {
  display: flex;
  align-items: center;
  color: #999;
  font-size: 14px;
}

.post-date {
  margin-right: 10px;
}

.post-edited {
  color: #909399;
  font-style: italic;
}

.post-content {
  margin: 15px 0;
  color: #666;
  line-height: 1.6;
}

.post-footer {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-top: 15px;
  padding-top: 15px;
  border-top: 1px solid #eee;
}

.post-stats span {
  margin-right: 20px;
  color: #909399;
}

.post-actions .el-button {
  padding: 0 10px;
}

.delete-btn {
  color: #F56C6C;
}

.post-actions i {
  margin-right: 3px;
}

.el-empty {
  padding: 40px 0;
}

.avatar-uploader {
  display: inline-block;
  width: 100px;
  height: 100px;
  border: 1px dashed #d9d9d9;
  border-radius: 50%;
  cursor: pointer;
  overflow: hidden;
  position: relative;
}

.avatar-uploader-icon {
  font-size: 28px;
  color: #8c939d;
  line-height: 100px;
  text-align: center;
}

.avatar {
  width: 100%;
  height: 100%;
  display: block;
}

.light .profile-card,
.light .post-card {
  background-color: #ffffff;
  color: #000000;
}

.dark .profile-card,
.dark .post-card {
  background-color: #2c3e50;
  color: #ffffff;
}

.el-input {
  transition: background-color 0.3s, color 0.3s;
}

.light .el-input__inner {
  background-color: #ffffff;
  color: #000000;
}

.dark .el-input__inner {
  background-color: #2c3e50;
  color: #ffffff;
}
</style>