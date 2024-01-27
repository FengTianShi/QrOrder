<template>
  <div class="container-fluid">
    <div class="row px-1">
      <div class="col-9 p-0">
        <nav class="navbar">
          <Brand />
        </nav>
      </div>
      <div class="col-3 navbar d-flex flex-row-reverse">
        <MainMenu />
      </div>
    </div>
  </div>
</template>

<script>
import Brand from "@/components/Brand.vue";
import MainMenu from "@/components/MainMenu.vue";

export default {
  components: { Brand, MainMenu },
};
</script>

<style scoped></style>
