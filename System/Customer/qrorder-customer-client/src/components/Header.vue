<template>
  <nav class="navbar">
    <div class="container-fluid">
      <Brand />
      <Menu />
    </div>
  </nav>
</template>

<script>
import Brand from "@/components/Brand.vue";
import Menu from "@/components/Menu.vue";

export default {
  components: { Brand, Menu },
};
</script>

<style scoped></style>
