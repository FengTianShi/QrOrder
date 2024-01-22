<template>
  <div class="modal fade" id="cart" tabindex="-1">
    <div
      class="modal-dialog modal-dialog-centered modal-dialog-scrollable modal-fullscreen-sm-down"
      style="max-width: 600px">
      <div class="modal-content">
        <div class="modal-header p-0 pe-4">
          <nav class="navbar">
            <div class="container-fluid">
              <Brand />
            </div>
          </nav>
          <button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close" />
        </div>
        <div class="modal-body p-0">
          <h1 class="text-center p-4">Cart</h1>
        </div>

        <div class="d-grid">
          <button class="btn btn-danger rounded-pill m-2" type="button">
            <i class="bi bi-cart-check me-1" style="font-size: 18px" />
            <span class="me-1">注文する</span>
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Brand from "@/components/Brand.vue";

export default {
  components: { Brand },
};
</script>

<style scoped></style>
